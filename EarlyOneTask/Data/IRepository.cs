using EarlyOneTask.Helpers.Models;
using EarlyOneTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Data
{
    public interface IRepository
    {
        Task<AccountSession> GetAccountBySessionToken(string token);
        Task<AccountSubject> AssigneSubject(AssignRequest assignRequest);
        Task<StudentScore> GiveScore(GiveScoreRequest giveScoreRequest, int id);
        Task<List<StudentScore>> GetScoresByStudentId(ScoreViewRequest scoreView);
        Task<List<StudentScore>> GetScores(ScoreViewRequest scoreView);
        Task<Account> GetAccountById(int? accountId);
    }
}
