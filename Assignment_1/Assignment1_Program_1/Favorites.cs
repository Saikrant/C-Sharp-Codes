namespace Assignment_1
{
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void favQuote_Click(object sender, EventArgs e)
        {

            label2.Text = MyFavorites.DisplayFavoriteQuote();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void favPlace_Click(object sender, EventArgs e)
        {
            label2.Text = MyFavorites.DisplayFavoritePlace();

        }

        private void favSong_Click(object sender, EventArgs e)
        {
            label2.Text = MyFavorites.DisplayFavoriteSong();

        }

        private void favFood_Click(object sender, EventArgs e)
        {
            label2.Text = MyFavorites.DisplayFavoriteFood();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void favMovie_Click(object sender, EventArgs e)
        {
            label2.Text=MyFavorites.DisplayFavoriteMovie();
        }
    }
}
