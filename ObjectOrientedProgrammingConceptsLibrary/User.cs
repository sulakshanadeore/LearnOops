using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class User
    {
		private string _username;

		public string Username
		{
			get { return _username; }
			set { _username = value;
				
			}
		}

		//read only property
		private string _password= "P@ssw0rd@123";
        public string Password 
		{ 
			get { return _password; }
			
		}

		private DateTime _joiningDate;

		//Write only property
		public DateTime JoiningDate
		{
		
			set { _joiningDate = value; }
		}

		public void DisplayJoiningDate()
		{
            Console.WriteLine(_joiningDate);
		}


	}
}
