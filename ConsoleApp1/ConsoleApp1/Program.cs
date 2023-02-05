// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using static ConsoleApp1.MLModel1;

Console.WriteLine("taxi fare is!");
//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Vendor_id = @"VTS",
    Rate_code = 1F,
    Passenger_count = 1F,
    Trip_time_in_secs = 480F,
    Trip_distance = 2.72F,
    Payment_type = @"CRD",
};
var input = new ModelInput();
{
    input.Trip_distance = 100;
    input.Trip_time_in_secs = 1000;
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.Score);
