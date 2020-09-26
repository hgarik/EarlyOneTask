using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EarlyOneTask.Data;
using EarlyOneTask.Helpers.Models;
using EarlyOneTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EarlyOneTask.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IRepository _repository;

        public ActionController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("AssigneSubject")]
        public async Task<ActionResult<AccountSubject>> AssigneSubject([FromBody] AssignRequest assignRequest)
        {
            var session = _repository.GetAccountBySessionToken(assignRequest.Token);
            var account = _repository.GetAccountById((await session).AccountId);

            if ((await account).Role.Id != (int)Roles.Principal)
                throw new Exception("NoPermission");

            return await _repository.AssigneSubject(assignRequest);
        }

        [HttpPost]
        [Route("giveScore")]
        public async Task<ActionResult<StudentScore>> GiveScore([FromBody] GiveScoreRequest giveScoreRequest)
        {
            var session = await _repository.GetAccountBySessionToken(giveScoreRequest.Token);
            var account = await _repository.GetAccountById(session.AccountId);

            if (account.RoleId != (int)Roles.Teacher)
                throw new Exception("NoPermission");

            var studentScore = await _repository.GiveScore(giveScoreRequest, session.Account.Id);

            return studentScore;

        }
        [HttpPost]
        [Route("scoreView")]
        public async Task<ActionResult<List<StudentScore>>> scoreView([FromBody] ScoreViewRequest scoreView)
        {
            AccountSession session = await _repository.GetAccountBySessionToken(scoreView.Token);
            var account = await _repository.GetAccountById(session.AccountId);
            if (account.RoleId == (int)Roles.Student)
            {
                return await _repository.GetScoresByStudentId(scoreView);
            }

            if (account.RoleId == (int)Roles.Student)
                return await _repository.GetScores(scoreView);

            throw new Exception("NoPermission");

        }
    }
}