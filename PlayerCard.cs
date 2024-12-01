using static A03.Form1;

namespace A03
{
    public partial class PlayerCard : Form
    {
        private Player _player;
        public PlayerCard(Player player)
        {
            InitializeComponent();
            _player = player; 
            //LoadPlayerDetails();
            BindPlayerDetails();
        }

        private void BindPlayerDetails()
        {
            //picPlayer.DataBindings.Clear();
            if (string.IsNullOrEmpty(_player.img))
            {
                picPlayer.Image = Image.FromFile(".\\img\\00.png");
            }
            else
            {
                picPlayer.Image = Image.FromFile(_player.img);
            }

            lblName.DataBindings.Add("Text", _player, "Name");
            lblTeam.DataBindings.Add("Text", _player, "Team");
            lblAge.DataBindings.Add("Text", _player, "Age");
            lblPts.DataBindings.Add("Text", _player, "PointsPerGame");
            lblReb.DataBindings.Add("Text", _player, "ReboundsPerGame");
            lblAst.DataBindings.Add("Text", _player, "AssistsPerGame");

            // Change text color to red if value is over 10
            SetLabelColor(lblPts, _player.PointsPerGame);
            SetLabelColor(lblReb, _player.ReboundsPerGame);
            SetLabelColor(lblAst, _player.AssistsPerGame);

            switch (_player.TeamAcronym)
            {
                case "CLE":
                    this.BackColor = ColorTranslator.FromHtml("#6f263d");
                    picTeam.Image = Image.FromFile(".\\img\\CLE.png");
                    break;
                case "DAL":
                    this.BackColor = ColorTranslator.FromHtml("#0053bc");
                    picTeam.Image = Image.FromFile(".\\img\\DAL.png");
                    break;
                case "NYK":
                    this.BackColor = ColorTranslator.FromHtml("#F58426");
                    picTeam.Image = Image.FromFile(".\\img\\NYK.png");
                    break;
                default:
                    this.BackColor = Color.LightGray;
                    break;
            }
        }


        private void SetLabelColor(Label label, double value)
        {
            if (value > 10)
            {
                label.ForeColor = Color.Red;
                label.BackColor = Color.Yellow;
            }
        }


    }
}
