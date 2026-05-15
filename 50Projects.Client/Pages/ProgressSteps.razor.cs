namespace _50Projects.Client.Pages
{
    public partial class ProgressSteps
    {
        private const int TotalSteps = 4;
        int currentActive = 1;
        private string ProgressWidth => $"{(currentActive - 1) * 100 / (TotalSteps - 1)}%";

        private void OnNextClicked()
        {
            currentActive++;

            if (currentActive > 4)
            {
                currentActive = 4;
            }

            Update();
        }

        private void OnPreviousClicked()
        {
            currentActive--;

            if (currentActive < 1)
            {
                currentActive = 1;
            }

            Update();
        }

        private void Update()
        { 
            
        }
    }
}