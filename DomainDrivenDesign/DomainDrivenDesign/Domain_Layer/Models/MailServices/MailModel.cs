namespace Domain_Layer.Models.MailServices
{
    public class MailModel
    {
        /// <summary>
        /// Mail atacağımız adresi barındıran değer
        /// </summary>
        public string MailTo { get; set; }

        /// <summary>
        /// Mail konusu
        /// </summary>
        public string MailSubject { get; set; }

        /// <summary>
        /// Mail İçeriği
        /// </summary>
        public string MailBody { get; set; }

        /// <summary>
        /// Birden fazla adrese mail atmak için virgüller ile ayrılır örnek: buraksecer@sodyum.com,burakscr@gmail.com gibi.
        /// </summary>
        private string[] _emailToList;
        public string[] MailToList
        {
            get { return _emailToList; }
            set
            {
                if (object.Equals(value, null) && !string.IsNullOrEmpty(MailTo))
                {
                    if (MailTo.Contains(","))
                    {
                        string[] emailParts = MailTo.Split(',');
                        _emailToList = new string[emailParts.Length];
                        for (int i = 0; i < emailParts.Length; i++)
                        {
                            _emailToList[i] = emailParts[i];
                        }
                    }
                    else
                    {
                        _emailToList = new string[] { MailTo };
                    }
                }
                else
                {
                    _emailToList = value;
                }
            }
        }
    }
}
