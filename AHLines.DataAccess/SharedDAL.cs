using System;
using System.Configuration;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class SharedDAL
    {
        public async Task<dynamic> GetLatestGuessAsync()
        {
            try
            {
                using (AHLinesContext ahLinesContext = new AHLinesContext())
                {
                    DateTime dateTime = Convert.ToDateTime("2018-08-08");

                    var latestGuess = await ahLinesContext.Guess
                        .FirstOrDefaultAsync(g => g.StartDate <= dateTime && g.EndDate >= dateTime);

                    return new
                    {
                        ImageUrl = ConfigurationManager.AppSettings["ImagePrefixUrl"] + latestGuess.QuizImageUrl
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}