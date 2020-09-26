using EarlyOneTask.Helpers.Models;
using EarlyOneTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Data.Repository
{
    public class ActionRepository : IRepository
    {
        private readonly TaskContext _context;
        public ActionRepository(TaskContext dbContext)
        {
            this._context = dbContext;
        }
        public async Task<AccountSubject> AssigneSubject(AssignRequest assignRequest)
        {
            var accountSubject = new AccountSubject
            {
                AccountId = assignRequest.AccountId,
                SubjectId = assignRequest.SubjectId
            };

            _context.Set<AccountSubject>().Add(accountSubject);
            await _context.SaveChangesAsync();
            return accountSubject;

        }

        public async Task<Account> GetAccountById(int? accountId)
        {
            return await _context.Account.FirstOrDefaultAsync(u => u.Id == accountId);
        }

        public async Task<AccountSession> GetAccountBySessionToken(string token)
        {
            return await _context.AccountSession.FirstOrDefaultAsync(u => u.Token == token);
        }

        public async Task<List<StudentScore>> GetScores(ScoreViewRequest scoreView)
        {
            return await _context.StudentScore.ToListAsync();
        }

        public async Task<List<StudentScore>> GetScoresByStudentId(ScoreViewRequest scoreView)
        {
            return await _context.StudentScore.Where(s=>s.StudentId==scoreView.AccountId).ToListAsync();
        }

        public async Task<StudentScore> GiveScore(GiveScoreRequest giveScoreRequest, int providedById)
        {

            var scoreModel = new StudentScore()
            {
                StudentId = giveScoreRequest.StudentId,
                SubjectId = giveScoreRequest.SubjectId,
                Value = giveScoreRequest.Score,
                ProvidedById = providedById
            };
            _context.Set<StudentScore>().Add(scoreModel);
            await _context.SaveChangesAsync();
            return scoreModel;
        }
    }
}
