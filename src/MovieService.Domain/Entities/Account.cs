using MovieService.Domain.ValueObjects;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MovieService.Domain.Entities
{
    public class Account
    {
        public Account() { }

        public Account(Guid id, Email username, string password, string role)
        {
            Id = id;
            UserName = username;
            Password = EncryptPassword(password);
            Role = role;
        }

        public Guid Id { get; private set; }
        public Email UserName { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public override string ToString()
        {
            return UserName.ToString();
        }

        //public void ChangePassword(string oldPassword, string newPassword)
        //{
        //    if (Password.Equals(EncryptPassword(oldPassword)))
        //        Password = EncryptPassword(newPassword);
        //    else
        //        AddNotification(oldPassword, "A senha atual está incorreta.");
        //}

        public void ResetPassword(string newPassword)
        {
            Password = EncryptPassword(newPassword);
        }

        public string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) 
                return "";

            var password = (pass += "e1c38fa0-9e6d-4142-8918-6fa5f1409a4c");
            var md5 = MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
