using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace CheonSeong_Accounting
{
    public class DBManager
    {
        #region 전역변수
        private string FileName;        //파일이름
        public string Imex;            //가져올때 : 1, 입력할때 : 0(0 : 이미들어있는 데이터 타입으로 업데이트)
        private bool hasHeaders;        //헤더여부
        private string[] sheetNames;     //시트이름들.

        private OleDbConnection con;    //연결을 위한 객체
        private OleDbCommand command;   //쿼리실행을 위한 객체
        #endregion

        public DBManager(string fn, string imex, bool header) //파일이름 받아옴
        {
            FileName = fn;
            Imex = imex;
            hasHeaders = header;

            sheetNames = new string[]{"Data","inType","outType","People"};

        }
        #region 엑셀연결함수
        private string ExcelConnection()
        {
            return
                @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=" + this.FileName + ";" +
                @"Extended Properties=" + Convert.ToChar(34).ToString() +
                @"Excel 8.0;HDR=YES;" + this.ExcelConnectionOptions() + Convert.ToChar(34).ToString();
        }

        private string ExcelConnectionOptions()
        {
            string strOpts = "Imex=" + this.Imex + ";";
            if(this.hasHeaders)
            {
                strOpts += "HDR=Yes;";
            }
            else
            {
                strOpts += "HDR=No;";
            }
            return strOpts;
        }

        public void OpenExcel()
        {
            this.con = new OleDbConnection(ExcelConnection());
            this.con.Open();
        }

        public void CloseExcel()
        {
            con.Close();
        }
        #endregion

        #region 쿼리문
        public DataTable GetDataTable(string Sheet, string[] col) //조건있는 검색
        {
            try
            {
                if (this.con == null)
                {
                    throw new Exception("파일연결실패");
                }

                foreach(string s in sheetNames)
                {
                    if (s == Sheet)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("시트이름이 없습니다.");
                    }
                }

                string cmd = "";
                if(col[1] == "<<전체>>") { col[1] = ""; }
                if (col[2] == "<<전체>>") { col[2] = ""; }
                if (col[3] == "<<전체>>") { col[3] = ""; }
                if(col[4] == "")    //금액입력안하면
                {
                    cmd += @"SELECT * FROM [" + Sheet + "$" + "] WHERE [날자] = " + col[0]
                                                             + " AND [수입/지출] LIKE '%" + col[1] + "%'"
                                                             + " AND [구분] LIKE '%" + col[2] + "%'"
                                                             + " AND [이름] LIKE '%" + col[3] + "%'";
                }
                else
                {
                    cmd += @"SELECT * FROM [" + Sheet + "$" + "] WHERE [날자] = " + col[0]
                                                             + "AND [수입/지출] LIKE '%" + col[1] + "%'"
                                                             + "AND [구분] LIKE '%" + col[2] + "%'"
                                                             + "AND [이름] LIKE '%" + col[3] + "%'"
                                                             + "AND [금액] = " + col[4];
                }
                                                             
                                                             


                command = new OleDbCommand(cmd, con);

                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                this.command.CommandTimeout = 200;
                oleAdapter.SelectCommand = command;

                DataTable dt = new DataTable(Sheet);
                oleAdapter.FillSchema(dt, SchemaType.Source);
                oleAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDataTable(string Sheet) //조건없는 검색(콤보박스 세팅용)
        {
            try
            {
                if (this.con == null)
                {
                    throw new Exception("파일연결실패");
                }

                for (int i=0; i<sheetNames.Count(); i++)
                {
                    if (sheetNames[i] == Sheet)
                    {
                        break;
                    }
                    else
                    {
                        if(i == sheetNames.Count()-1)
                        {
                            throw new Exception("시트이름이 없습니다.");
                        }        
                    }     
                }

                string cmd = "";
                cmd += @"SELECT * FROM [" + Sheet + "$" + "]" + System.Environment.NewLine;


                command = new OleDbCommand(cmd, con);

                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                this.command.CommandTimeout = 200;
                oleAdapter.SelectCommand = command;

                DataTable dt = new DataTable(Sheet);
                oleAdapter.FillSchema(dt, SchemaType.Source);
                oleAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertData(string sheet, string value)  //데이터입력
        {
            try
            {
                string sql = "";
                switch (sheet)
                {
                    case "Data":
                        sql = @"INSERT INTO [" + sheet + "$" + "]([날자],[수입/지출],[구분],[이름],[금액],[비고])VALUES(" + value + ")";
                        command = new OleDbCommand(sql, con);
                        command.ExecuteNonQuery();                  
                        break;
                    case "inType":
                        sql = @"INSERT INTO [" + sheet + "$" + "] VALUES('" + value + "')";
                        command = new OleDbCommand(sql, con);
                        command.ExecuteNonQuery();
                        break;
                    case "outType":
                        sql = @"INSERT INTO [" + sheet + "$" + "] VALUES('" + value + "')";
                        command = new OleDbCommand(sql, con);
                        command.ExecuteNonQuery();
                        break;
                    case "People":
                        sql = @"INSERT INTO [" + sheet + "$" + "] VALUES('" + value + "')";
                        command = new OleDbCommand(sql, con);
                        command.ExecuteNonQuery();
                        break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update_Data(string sheet, string[] Old, string[] New)   //데이터 업데이트
        {
            try
            {
                string sql = "";
                sql = @"UPDATE [" + sheet + "$" + "] SET [날자] =" + New[0] + ","
                                                       + "[수입/지출] ='" + New[1] + "',"
                                                       + "[구분] ='" + New[2] + "',"
                                                       + "[이름] ='" + New[3] + "',"
                                                       + "[금액] =" + New[4] + ","
                                                       + "[비고] ='" + New[5] + "'"
                                                       + "WHERE [날자] =" + Old[0] + ""
                                                       + "AND [수입/지출] ='" + Old[1] + "'"
                                                       + "AND [구분] ='" + Old[2] + "'"
                                                       + "AND [이름] ='" + Old[3] + "'"
                                                       + "AND [금액] =" + Old[4] + ""
                                                       + "AND [비고] ='" + Old[5] + "'";
                command = new OleDbCommand(sql, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Calculate_in(string date, string when)  //수입정산
        {
            try
            {
                if (this.con == null)
                {
                    throw new Exception("파일연결실패");
                }

                string cmd = "";

                switch(when)
                {
                    case "Today" :
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] = " + date
                                                                            + " AND [수입/지출] = '수입'"
                                                                            + " GROUP BY [구분]";
                        break;
                    case "Mon":
                        string Mon1, Mon2;
                        Mon1 = date.Substring(0, 6) + "01";
                        Mon2 = date.Substring(0, 6) + "31";
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] >= " + Mon1
                                                                            + " AND [날자] <= " + Mon2
                                                                            + " AND [수입/지출] = '수입'"
                                                                            + " GROUP BY [구분]";
                        break;
                    case "Year":
                        string Y1, Y2;
                        Y1 = date.Substring(0, 4) + "0101";
                        Y2 = date.Substring(0, 4) + "1231";
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] >= " + Y1
                                                                            + " AND [날자] <= " + Y2
                                                                            + " AND [수입/지출] = '수입'"
                                                                            + " GROUP BY [구분]";
                        break;
                    case "Person":
                        string y1, y2;
                        y1 = date.Substring(0, 4) + "0101";
                        y2 = date.Substring(0, 4) + "1231";
                        cmd += @"SELECT [이름],[구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] >= " + y1
                                                                            + " AND [날자] <= " + y2
                                                                            + " AND [수입/지출] = '수입'"
                                                                            + " GROUP BY [이름],[구분]";
                        break;
                }
                
                command = new OleDbCommand(cmd, con);

                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                this.command.CommandTimeout = 200;
                oleAdapter.SelectCommand = command;

                DataTable dt = new DataTable("Calculate");
                oleAdapter.FillSchema(dt, SchemaType.Source);
                oleAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Calculate_out(string date, string when) //지출정산
        {
            try
            {
                if (this.con == null)
                {
                    throw new Exception("파일연결실패");
                }

                string cmd = "";

                switch (when)
                {
                    case "Today":
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] = " + date
                                                                            + " AND [수입/지출] = '지출'"
                                                                            + " GROUP BY [구분]";
                        break;
                    case "Mon":
                        string Mon1, Mon2;
                        Mon1 = date.Substring(0, 6) + "01";
                        Mon2 = date.Substring(0, 6) + "31";
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] >= " + Mon1
                                                                            + " AND [날자] <= " + Mon2
                                                                            + " AND [수입/지출] = '지출'"
                                                                            + " GROUP BY [구분]";
                        break;
                    case "Year":
                        string Y1, Y2;
                        Y1 = date.Substring(0, 4) + "0101";
                        Y2 = date.Substring(0, 4) + "1231";
                        cmd += @"SELECT [구분],SUM([금액]) AS 합계 FROM [Data$] WHERE [날자] >= " + Y1
                                                                            + " AND [날자] <= " + Y2
                                                                            + " AND [수입/지출] = '지출'"
                                                                            + " GROUP BY [구분]";
                        break;
                }

                command = new OleDbCommand(cmd, con);

                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                this.command.CommandTimeout = 200;
                oleAdapter.SelectCommand = command;

                DataTable dt = new DataTable("Calculate");
                oleAdapter.FillSchema(dt, SchemaType.Source);
                oleAdapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }

}
