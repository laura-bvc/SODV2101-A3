using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static A03.Form1;
using System.Xml.Linq;

namespace A03
{
    public partial class PlayerEdit : Form
    {
        private Player _player;
        private List<Player> _players;
        private Action _refreshDataGridView;

        public PlayerEdit(Player player, List<Player> players, Action refreshDataGridView, string buttonText)
        {
            InitializeComponent();
            _player = player;
            _players = players;
            _refreshDataGridView = refreshDataGridView;

            this.Text = buttonText + " Player";
            btnEdit.Text = buttonText;

            SetupDataBindings();
            /*
            if (buttonText =="Add")
            {
                int maxId = _players.Any() ? _players.Max(p => p.Id) : 0;
                _player.Id = maxId + 1;
                txtId.Text = _player.Id.ToString();
            }
            */
        }

        private void SetupDataBindings()
        {
            BindingSource playerBindingSource = new BindingSource { DataSource = _player };

            txtId.DataBindings.Add("Text", playerBindingSource, "Id");
            txtName.DataBindings.Add("Text", playerBindingSource, "Name");
            txtTeam.DataBindings.Add("Text", playerBindingSource, "Team");
            txtAge.DataBindings.Add("Text", playerBindingSource, "Age");
            //txtTeamAcronym.DataBindings.Add("Text", playerBindingSource, "TeamAcronym");
            txtPts.DataBindings.Add("Text", playerBindingSource, "PointsPerGame");
            txtReb.DataBindings.Add("Text", playerBindingSource, "ReboundsPerGame");
            txtAst.DataBindings.Add("Text", playerBindingSource, "AssistsPerGame");
            txtImg.DataBindings.Add("Text", playerBindingSource, "img");
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Player player = _player;

            switch (player.Team)
            {
                case "Cleveland Cavaliers":
                    _player.TeamAcronym = "CLE";
                    break;
                case "Dallas Mavericks":
                    _player.TeamAcronym = "DAL";
                    break;
                case "New York Knicks":
                    _player.TeamAcronym = "NYK";
                    break;
                default:
                    _player.TeamAcronym = "";
                    break;
            }

            if (this.Text == "Add Player")
            {
                // Add the player to the list
                _players.Add(_player);
                MessageBox.Show($"Player {_player.Name} added");
            }
            else if (this.Text == "Update Player")
            {
                // Update the existing player data
                var existingPlayer = _players.FirstOrDefault(p => p.Id == player.Id);
                if (existingPlayer != null)
                {
                    existingPlayer.Name = _player.Name;
                    existingPlayer.Team = _player.Team;
                    existingPlayer.TeamAcronym = _player.TeamAcronym;
                    existingPlayer.Age = _player.Age;
                    existingPlayer.PointsPerGame = _player.PointsPerGame;
                    existingPlayer.ReboundsPerGame = _player.ReboundsPerGame;
                    existingPlayer.AssistsPerGame = _player.AssistsPerGame;
                    existingPlayer.img = _player.img;
                    MessageBox.Show($"Player {_player.Name} updated");
                }
            }

            // Refresh DataGridView in the main form
            _refreshDataGridView?.Invoke();
            this.Close();
        }

    }





}
