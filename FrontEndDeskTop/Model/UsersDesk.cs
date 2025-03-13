using System;

namespace FrontEndDeskTop.Model
{
	public class UsersDesk : RequesteRegisterUser
	{
		public int Id { get; set; }
		public Guid UserIdentifier { get; set; }
	}
}
