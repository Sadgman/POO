public interface ICustomerRepository
{
    Customer GetCustomerById(int id);
}

public class CustomerRepository : ICustomerRepository
{
    public Customer GetCustomerById(int id)
    {
        return null;
    }
}

public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer GetCustomer(int id)
    {
        return _customerRepository.GetCustomerById(id);
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<CustomerService>();
    }
}
