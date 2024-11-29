using static A03.Form1;

namespace A03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = players.Select(p => new { p.Name, p.Team }).ToList();
        }

        public class Player
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Team { get; set; }
            public string TeamAcronym { get; set; }
            public int Age { get; set; }
            public double PointsPerGame { get; set; }
            public double ReboundsPerGame { get; set; }
            public double AssistsPerGame { get; set; }
            public string img {  get; set; }
        }

        List<Player> players = new List<Player>
    {
    new Player { Id = 1, Name = "Donovan Mitchell", Team = "Cleveland Cavaliers",
        TeamAcronym = "CLE", Age = 27, PointsPerGame = 29.6,
        ReboundsPerGame = 5.4, AssistsPerGame = 4.7, 
        img=".\\img\\1.png"},
    new Player { Id = 2, Name = "Jarrett Allen", Team = "Cleveland Cavaliers",
        TeamAcronym = "CLE", Age = 26, PointsPerGame = 17.0,
        ReboundsPerGame = 13.8, AssistsPerGame = 1.3,
        img=".\\img\\2.png"},
    new Player { Id = 3, Name = "Evan Mobley", Team = "Cleveland Cavaliers",
        TeamAcronym = "CLE", Age = 23, PointsPerGame = 16.0,
        ReboundsPerGame = 9.3, AssistsPerGame = 2.3,
        img=".\\img\\3.png"},
    new Player { Id = 4, Name = "Darius Garland", Team = "Cleveland Cavaliers",
        TeamAcronym = "CLE", Age = 24, PointsPerGame = 15.7,
        ReboundsPerGame = 3.6, AssistsPerGame = 5.8,
        img=".\\img\\4.png"},
    new Player { Id = 5, Name = "Luka Dončić", Team = "Dallas Mavericks",
        TeamAcronym = "DAL", Age = 25, PointsPerGame = 28.9,
        ReboundsPerGame = 9.5, AssistsPerGame = 8.1,
        img=".\\img\\5.png"},
    new Player { Id = 6, Name = "Kyrie Irving", Team = "Dallas Mavericks",
        TeamAcronym = "DAL", Age = 32, PointsPerGame = 22.1,
        ReboundsPerGame = 3.7, AssistsPerGame = 5.1,
        img=".\\img\\6.png"},
    new Player { Id = 7, Name = "P.J. Washington", Team = "Dallas Mavericks",
        TeamAcronym = "DAL", Age = 25, PointsPerGame = 13.0,
        ReboundsPerGame = 6.6, AssistsPerGame = 1.4,
       img=".\\img\\7.png"},
    new Player { Id = 8, Name = "Derrick Jones Jr.", Team = "Dallas Mavericks",
        TeamAcronym = "DAL", Age = 27, PointsPerGame = 9.1,
        ReboundsPerGame = 3.5, AssistsPerGame = 1.2,
        img=".\\img\\8.png"},
    new Player { Id = 9, Name = "Jalen Brunson", Team = "New York Knicks",
        TeamAcronym = "NYK", Age = 27, PointsPerGame = 32.4,
        ReboundsPerGame = 3.3, AssistsPerGame = 7.5,
        img=".\\img\\9.png"},
    new Player { Id = 10, Name = "Donte DiVincenzo", Team = "New York Knicks",
        TeamAcronym = "NYK", Age = 27, PointsPerGame = 17.8,
        ReboundsPerGame = 4.0, AssistsPerGame = 2.6,
        img=".\\img\\10.png"},
    new Player { Id = 11, Name = "OG Anunoby", Team = "New York Knicks",
        TeamAcronym = "NYK", Age = 26, PointsPerGame = 15.1,
        ReboundsPerGame = 6.0, AssistsPerGame = 1.1,
        img=".\\img\\11.png"},
    new Player { Id = 12, Name = "Alec Burks", Team = "New York Knicks",
        TeamAcronym = "NYK", Age = 32, PointsPerGame = 14.8,
        ReboundsPerGame = 3.3, AssistsPerGame = 1.0,
        img=".\\img\\12.png"}
    };

        private Dictionary<int, PlayerCard> openPlayerForms = new Dictionary<int, PlayerCard>();

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dataGridView1.SelectedCells)
            {
                var selectedPlayer = players[c.RowIndex];

                // Check if the form for this player is already open
                if (!openPlayerForms.ContainsKey(selectedPlayer.Id))
                {
                    // Create and show the player details form
                    PlayerCard card = new PlayerCard(selectedPlayer);
                    card.FormClosed += (s, args) => 
                        openPlayerForms.Remove(selectedPlayer.Id); // Remove from dictionary at close
                    openPlayerForms[selectedPlayer.Id] = card;
                    card.Show();
                }
                else
                {
                    // Bring the existing form to the front
                    openPlayerForms[selectedPlayer.Id].BringToFront();
                }
            }
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            int maxId = players.Any() ? players.Max(p => p.Id) : 0;
            player.Id = maxId + 1;
            PlayerEdit playerEditForm = new PlayerEdit(player, players, RefreshDataGridView, "Add");
            playerEditForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                var selectedPlayer = players[rowIndex];

                PlayerEdit playerEditForm = new PlayerEdit(selectedPlayer, players, RefreshDataGridView, "Update");
                playerEditForm.ShowDialog();
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row for update.", 
                    "Select only one row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a row for update.", 
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = players.Select(p => new { p.Name, p.Team }).ToList();
        }






        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedPlayer = players[dataGridView1.SelectedCells[0].RowIndex];

                // confirmation
                DialogResult result = MessageBox.Show($"Are you sure " +
                    $"you want to delete player {selectedPlayer.Name}?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove player from the list
                    players.Remove(selectedPlayer);

                    // Update DataGridView
                    dataGridView1.DataSource = players.Select(p => new { p.Name, p.Team }).ToList();

                    // Close any open PlayerCard form for the deleted player
                    if (openPlayerForms.ContainsKey(selectedPlayer.Id))
                    {
                        openPlayerForms[selectedPlayer.Id].Close();
                        openPlayerForms.Remove(selectedPlayer.Id);
                    }
                }
            }
            else if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row for delete.", 
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select only one row for delete.", 
                    "Delete one row at a time",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
