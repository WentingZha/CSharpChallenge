using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace CharsConsole
{
    class Console19Thread
    {
        public void setPriority() {
            Thread threadNormal = new Thread(new ThreadStart(() => Console.WriteLine("Normal Thread")));
            threadNormal.Priority = ThreadPriority.Lowest;
            Thread threadHighest = new Thread(new ThreadStart(() => Console.WriteLine("High Thread")));
            //Thread threadHighest = new Thread(new ThreadStart(() => rtbPriority.Text = "Thread1"));
            threadHighest.Priority = ThreadPriority.Highest;
            threadNormal.Start();
            threadHighest.Start();
         
        }

        public void threadLock() {
            lock (this)
            {
                Console.WriteLine("Lock to synchronize");   
            }
        }

        public void threadLock1()
        {
            Monitor.Enter(this);
            Console.WriteLine("Lock thread to synchronize 1");
            Monitor.Exit(this);
        }

        public void threadLock2()
        {
            Mutex mutex = new Mutex(false);
            mutex.WaitOne();
            Console.WriteLine("Lock thread to synchronize 2");
            mutex.ReleaseMutex();
        }



        string strConn = "server=ZhaWenTing;database=zhadb;uid=zhawenting;pwd=";
        SqlConnection sqlConn = null;
        Thread threadConn = null;
        Thread threadInsert = null;
        
        private void ThreadInsert()
        {

       
            sqlConn = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO DBUSER(NAME,BONUS,LEVEL) VALUES('GJF',1800,5)", sqlConn);
            sqlConn.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
          
        }

        private void ThreadConn()
        {

            sqlConn = new SqlConnection(strConn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbuser", sqlConn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
               Console.WriteLine(dataSet.Tables[0].Rows[i][0].ToString() + " " + dataSet.Tables[0].Rows[i][1].ToString()) ;

            }

        }

        public void startConnection()
        {
            threadConn = new Thread(new ThreadStart(ThreadConn));
            threadConn.Start();
        }


        public void insertData()
        {

            Mutex mutex = new Mutex(false);
            mutex.WaitOne();
            threadInsert = new Thread(new ThreadStart(ThreadInsert));
            threadInsert.Start();
            mutex.ReleaseMutex();
            Console.WriteLine("Inserted");
         
        }

    }
}
