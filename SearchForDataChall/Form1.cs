using System.ComponentModel;

namespace SearchForDataChall
{
    public partial class Form1 : Form
    {
        BindingList<string> searchBoxData = new();
        public Form1()
        {
            InitializeComponent();
            SearchResults.DataSource = searchBoxData;
            ChallangeChoice.DataSource = Enum.GetValues(typeof(challangeChoice));
        }
        
        enum challangeChoice
        {
            MainGoal,
            BonusChallange
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForDataProcessor sfd = new();
            switch (ChallangeChoice.SelectedItem)
            {
                case challangeChoice.MainGoal:

                    searchBoxData.Clear();
                    
                    List<string> results = sfd.SearchForText(SearchBox.Text, "primary.txt");

                    UpdateSearchResultsList(searchBoxData, results);
                    SearchBox.Text = "";

                    if(searchBoxData.Count == 0)
                    {
                        searchBoxData.Add("No results for the given string");
                    }

                    break;
                case challangeChoice.BonusChallange:

                    searchBoxData.Clear();

                    List<string> phoneNumbers = sfd.SearchForPhoneNumbers("bonus.txt");

                    UpdateSearchResultsList(searchBoxData, phoneNumbers);
                    SearchBox.Text = "";

                    if (searchBoxData.Count == 0)
                    {
                        searchBoxData.Add("No phone numbers found in text");
                    }

                    break;

            }
        }

        private void UpdateSearchResultsList(BindingList<string> searchBoxData, List<string> results)
        {
            foreach(string result in results)
            {
                searchBoxData.Add(result);
            }
        }
    }
}