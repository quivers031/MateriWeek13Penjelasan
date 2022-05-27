using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MateriWeek13
{
    public partial class Form_MateriWeek13 : Form
    {
        public Form_MateriWeek13()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtPemainDiTim = new DataTable();
        DataTable dtApakahKapten = new DataTable();
        DataTable umurPemain = new DataTable();

        int posisiSekarang = 0;
        string simpanIDLama = "";
        string teamIDLama = "";

        private void Form_MateriWeek13_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT nation as `Nation`, nationality_id as `ID` FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            cBox_Nationality.DataSource = dtNationality;
            cBox_Nationality.DisplayMember = "Nation";
            cBox_Nationality.ValueMember = "ID";

            sqlQuery = "SELECT team_name as `Nama`, team_id as `ID` FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBox_Team.DataSource = dtTeam;
            cBox_Team.DisplayMember = "Nama";
            cBox_Team.ValueMember = "ID";

            sqlQuery = "SELECT player_id, player_name, birthdate, nationality_id, team_id, team_number FROM player;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            TampilkanData(posisiSekarang);
        }

        private void TampilkanData(int posisi)
        {
            
            tBox_PlayerID.Text = dtPlayer.Rows[posisi][0].ToString();
            tBox_PlayerName.Text = dtPlayer.Rows[posisi][1].ToString();
            dtp_Birthdate.Value = Convert.ToDateTime(dtPlayer.Rows[posisi][2].ToString());
            cBox_Nationality.SelectedValue = dtPlayer.Rows[posisi][3].ToString();
            cBox_Team.SelectedValue = dtPlayer.Rows[posisi][4].ToString();
            nUD_TeamNumber.Value = Convert.ToInt32(dtPlayer.Rows[posisi][5].ToString());
            simpanIDLama = tBox_PlayerID.Text;
            teamIDLama = cBox_Team.SelectedValue.ToString();
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            posisiSekarang = 0;
            TampilkanData(posisiSekarang);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            posisiSekarang--;
            TampilkanData(posisiSekarang);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            posisiSekarang++;
            TampilkanData(posisiSekarang);
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            posisiSekarang = dtPlayer.Rows.Count - 1;
            TampilkanData(posisiSekarang);
        }

        private void nUD_TeamNumber_ValueChanged(object sender, EventArgs e)
        {
            CekNomorPunggung();
        }

        private void cBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            CekNomorPunggung();
        }

        private void CekNomorPunggung()
        {
            dtPemainDiTim = new DataTable();
            sqlQuery = "SELECT * FROM player WHERE team_id = '" + cBox_Team.SelectedValue.ToString() + "' AND team_number = '" + nUD_TeamNumber.Value.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemainDiTim);
            if (dtPemainDiTim.Rows.Count != 0)
            {
                label_Available.Text = "Not Available";
            }
            else
            {
                label_Available.Text = "Available";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (label_Available.Text == "Available")
            {
                sqlQuery = "UPDATE player SET player_id = '" + tBox_PlayerID.Text + "', player_name = '" + tBox_PlayerName.Text + "', birthdate = '" + dtp_Birthdate.Value.ToString("yyyyMMdd") + "', nationality_id = '" + cBox_Nationality.SelectedValue.ToString() + "', team_id = '" + cBox_Team.SelectedValue.ToString() + "', team_number = '" + nUD_TeamNumber.Value.ToString() + "' WHERE player_id = '" + simpanIDLama + "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "SELECT * FROM team WHERE team_id = '" + teamIDLama + "' AND captain_id = '" + simpanIDLama + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtApakahKapten);

                if (dtApakahKapten.Rows.Count != 0)
                {
                    sqlQuery = "SELECT player_id FROM player WHERE team_id = '"+teamIDLama+"' ORDER BY birthdate asc;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(umurPemain);

                    sqlQuery = "UPDATE team SET captain_id = '"+umurPemain.Rows[0][0].ToString()+"' WHERE team_id = '"+teamIDLama+"'";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                }
            }
            else
            {
                MessageBox.Show("EEROROR");
            }


        }
    }
}
