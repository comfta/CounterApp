namespace CounterApp
{
    public partial class MainPage : ContentPage
    {
        private int counterValue = 0;

        public MainPage()
        {
            InitializeComponent();
            UpdateCounterDisplay();
        }

        private void OnPlusButtonClicked(object sender, EventArgs e)
        {
            counterValue++;
            UpdateCounterDisplay();
        }

        private void OnMinusButtonClicked(object sender, EventArgs e)
        {
            counterValue--;
            UpdateCounterDisplay();
        }

        private void UpdateCounterDisplay()
        {
            CounterLabel.Text = counterValue.ToString();
        }
    }
}