using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class UserRepos : BaseRepository<Users>, IUserRepos
    {
        public UserRepos(Context context) : base(context)
        {

        }

		public Users Login(Users user)
		{
			var dummyUser = new Users();
			try
			{

				var loginUser = Set().FirstOrDefault(x => x.UserName == user.UserName);
				if (loginUser != null)
				{
					bool verified = BCrypt.Net.BCrypt.Verify(user.Password , loginUser.Password);
					if (verified)
					{
						return loginUser;
					}
				}
				return dummyUser;
			}
			catch (Exception)
			{
				return dummyUser;
			}
		}

		public void Logout()
		{
			throw new NotImplementedException();
		}

		public bool Register(Users user)
		{
			try
			{
				// Passwordu encrypt olarak saklar.
				user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
				user.CreatedDate = DateTime.Now;
				user.LastUpdated = DateTime.Now;
				Add(user);

				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
}
