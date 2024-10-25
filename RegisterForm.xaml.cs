namespace MauiApp4;
public partial class RegisterForm : ContentPage
{
    public RegisterForm()
    {
        InitializeComponent();
        ExperienceSlider.ValueChanged += OnSliderValueChanged;
        DependentsStepper.ValueChanged += OnStepperValueChanged;
    }

    // Update experience label when slider value changes
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        ExperienceLabel.Text = $"{e.NewValue} years";
    }

    // Update dependents label when stepper value changes
    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        DependentsLabel.Text = $"{e.NewValue}";
    }

    // Handle register button click
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        DateTime dob = DobPicker.Date;
        string gender = MaleRadioButton.IsChecked ? "Male" : "Female";
        string agreedToTerms = TermsSwitch.IsToggled ? "Yes" : "No";
        double experience = ExperienceSlider.Value;
        int dependents = (int)DependentsStepper.Value;

        // Display summary
        await DisplayAlert("Registration",
            $"Name: {name}\nEmail: {email}\nDOB: {dob.ToString("dd/MM/yyyy")}\nGender: {gender}\nExperience: {experience} years\nDependents: {dependents}\nAgreed to Terms: {agreedToTerms}",
            "OK");
    }
}