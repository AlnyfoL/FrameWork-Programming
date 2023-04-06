using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    private readonly BMIResultRepository _bmiResultRepository;
    public App(BMIResultRepository bmiResultRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();

        _bmiResultRepository = bmiResultRepository;
    }
}
