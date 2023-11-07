using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected string PasswordHasher(string text)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(text);
            SHA512 sha512 = SHA512.Create();
            byte[] hash = sha512.ComputeHash(textAsByte);

            return $"{ Convert.ToBase64String(hash)}";

        }
    }

    

}
