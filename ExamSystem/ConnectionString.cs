namespace ExamSystem
{
    class ConnectionString:IPAdress
    {
        //public string DbConn = "Data Source=duho-pc;Initial Catalog=Exam;Integrated Security=True;MultipleActiveResultSets=True";

        public string Connect()
        {
           string add = ReadFile();
            string DbConn = @"Data Source=" + add + ",1433;Network Library=DBMSSOCN;Initial Catalog = Exam; User ID = ExamApp;MultipleActiveResultSets=True; Password =ExamApplication; ";
            return DbConn;
        }

    }
}
