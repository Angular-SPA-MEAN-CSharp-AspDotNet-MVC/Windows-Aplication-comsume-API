using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2
{
    public class PrimeGameController : ApiController
    {
        public PrimeNumGame gameRes = new PrimeNumGame
        {
            resString = "Intial not result"
        };

        // This function is used to check whether a number is a prime one, internally.
        private bool isPrime(long number)
        {
            if (number <= 1) 
                return false;
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
                return false;
            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }

        public IHttpActionResult GetPrimeGame(int id)
        {
            int next1 = 0 , next2= 0;

            /* Take care of the invalid input, should handle this in the front-end
            int n;
            bool isNumeric = int.TryParse("123", out n);
            if (!isNumeric)
            {
                gameRes.resString = "Please enter a valid input, it should be a number";
                return Ok(gameRes);
            }
            */

            if (!isPrime(id))
            {
                gameRes.resString = "Not a Prime number, error code -1";
            }
            else
            {
                for(int i = id+2 ; ; i +=2)
                {
                    if( next1==0 && isPrime(i) )
                    {
                        next1 = i;
                    }
                    else if ( next2==0 && isPrime(i) )
                    {                    
                        next2 = i;
                        break;
                    }
                }
                gameRes.resString = "Next two Prime numbers are : "+ next1 + " and " + next2 ;
            }
            return Ok(gameRes);
        }
    }
}
