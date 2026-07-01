using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player; // Declare a private field to hold the player object { Datatype : Player, Name: _player, AccessModifier: private}
        public SuperAdventure()
        {
            InitializeComponent();


            _player = new Player(10, 10, 20, 0, 1);  // Create a new instance of the Player class and assign it to the _player field

            lblHitPoints.Text = _player.CurrentHitPoints.ToString(); // Display the player's current hit points in the lblHitPoints label
            lblGold.Text = _player.Gold.ToString();                 // Display the player's gold in the lblGold label
            lblExperience.Text = _player.ExperiencePoints.ToString(); // Display the player's experience points in the lblExperience label
            lblLevel.Text = _player.Level.ToString(); // Display the player's level in the lblLevel label
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
