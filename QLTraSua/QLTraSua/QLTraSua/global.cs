namespace QLTraSua
{
    internal class global
    {
        private static string _username = "";
        private static string _password = "";

        private static int tableID;

        public static int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        public static string GetSetUsername
        {
            get { return _username; }
            set { _username = value; }
        }
        public static string GetSetPassword
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}