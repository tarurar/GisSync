using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.ETEA.Schema.Workers.SetBacks
{
    public class CreateWorker : ETEABaseWorker
    {
        public override void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
        {
            base.Execute(source, dest, statusCallback);

            // insert smth to dest
            statusCallback(33, "Creating new setbacks");

            // insert smth to dest
            statusCallback(66, "Creating new setbacks");

            //insert smth to dest
            statusCallback(100, "Creating new setbacks");
        }
    }
}
