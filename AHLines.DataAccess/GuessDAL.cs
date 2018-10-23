using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class GuessDAL
    {
        public async Task<IEnumerable<dynamic>> GetGuessListAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    var guessList = await ahLinesContext.Guess
                        .Select(g => new
                        {
                            g.GuessId,
                            g.QuizImageUrl,
                            g.AnswerImageUrl,
                            g.AnswerName
                        })
                        .ToListAsync();

                    return guessList.Select(g => new
                    {
                        GuessId = g.GuessId,
                        QuizImageUrl = ConfigurationManager.AppSettings["ImagePrefixUrl"] + g.QuizImageUrl,
                        AnswerImageUrl = ConfigurationManager.AppSettings["ImagePrefixUrl"] + g.AnswerImageUrl,
                        AnswerName = g.AnswerName
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}