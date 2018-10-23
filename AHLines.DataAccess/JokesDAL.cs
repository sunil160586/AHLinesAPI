using AHLines.DataModel;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AHLines.DataAccess
{
    public class JokesDAL
    {
        public async Task<ICollection<Joke>> GetJokes()
        {
            ICollection<Joke> jokes = new List<Joke>();

            try
            {
                SqlDataReader sqlDataReader = await Task.Run(() => SqlHelper.ExecuteReader(DBConnection.SqlConnectionString, CommandType.StoredProcedure, StoredProcedures.JokesList));

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        jokes.Add(await Task.Run(() => GetJokeDetails(sqlDataReader)));
                    }
                }
            }
            catch (Exception)
            {
                jokes = null;
            }            

            return jokes;
        }

        public async Task<Joke> GetJokeDetails(int? jokeId)
        {
            Joke joke = new Joke();
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@JokeId", SqlDbType.Int);
            sqlParameter[0].Value = jokeId;

            try
            {
                SqlDataReader sqlDataReader = await Task.Run(() => SqlHelper.ExecuteReader(DBConnection.SqlConnectionString, CommandType.StoredProcedure, StoredProcedures.JokeDetails, sqlParameter));

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        joke = await Task.Run(() => GetJokeDetails(sqlDataReader));
                    }
                }
            }
            catch (Exception)
            {
                joke = null;
            }                        

            return joke;
        }

        async Task<Joke> GetJokeDetails(SqlDataReader sqlDataReader)
        {
            Joke joke = new Joke();

            await Task.Run(() =>
            {
                joke.AuthorEmail = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["AuthorEmail"])) ? string.Empty : Convert.ToString(sqlDataReader["AuthorEmail"]);
                joke.CreatedBy = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["CreatedBy"])) ? string.Empty : Convert.ToString(sqlDataReader["CreatedBy"]);
                joke.CreatedDate = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["CreatedDate"])) ? Convert.ToDateTime(null) : Convert.ToDateTime(sqlDataReader["CreatedDate"]);
                joke.JokeAbstract = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeAbstract"])) ? string.Empty : Convert.ToString(sqlDataReader["JokeAbstract"]);
                joke.JokeAuthor = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeAuthor"])) ? string.Empty : Convert.ToString(sqlDataReader["JokeAuthor"]);
                joke.JokeCaption = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeCaption"])) ? string.Empty : Convert.ToString(sqlDataReader["JokeCaption"]);
                joke.JokeCategory = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeCategory"])) ? string.Empty : Convert.ToString(sqlDataReader["JokeCategory"]);
                joke.JokeDescription = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeDesc"])) ? string.Empty : Convert.ToString(sqlDataReader["JokeDesc"]);
                joke.JokeId = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeId"])) ? 0 : Convert.ToInt32(sqlDataReader["JokeId"]);
                joke.JokeStatus = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["JokeStatus"])) ? false : Convert.ToBoolean(sqlDataReader["JokeStatus"]);
                joke.ModifiedBy = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["ModifiedBy"])) ? string.Empty : Convert.ToString(sqlDataReader["ModifiedBy"]);
                joke.ModifiedDate = string.IsNullOrEmpty(Convert.ToString(sqlDataReader["ModifiedDate"])) ? Convert.ToDateTime(null) : Convert.ToDateTime(sqlDataReader["ModifiedDate"]);
            });
            
            return joke;
        }
    }
}