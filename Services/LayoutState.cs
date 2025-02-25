namespace SafeGuard.Services
{
    public class LayoutState
    {
        public int Progress { get; private set; }

        public event Action? OnChange; // Event to notify UI of updates

        public void UpdateProgress(int percent)
        {
            Progress = percent;
            OnChange?.Invoke(); // Notify any listeners to refresh UI
        }
    }
}
