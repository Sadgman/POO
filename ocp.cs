public interface ITaxStrategy {
    decimal CalculateTax(decimal ti);
}

public class IndiaTaxStrategy : ITaxStrategy {
    public decimal CalculateTax(decimal ti) {
        return ti * 0.10m; 
    }
}

public class USATaxStrategy : ITaxStrategy {
    public decimal CalculateTax(decimal ti) {
        return ti * 0.20m; 
    }
}

public class UKTaxStrategy : ITaxStrategy {
    public decimal CalculateTax(decimal ti) {
        return ti * 0.15m;
    }
}

public class CalcImpuestos {
    private readonly Dictionary<string, ITaxStrategy> _estrategias;

    public CalcImpuestos() {
        _estrategias = new Dictionary<string, ITaxStrategy> {
            { "India", new IndiaTaxStrategy() },
            { "USA", new USATaxStrategy() },
            { "UK", new UKTaxStrategy() }
        };
    }

    public decimal Calcular(decimal ingreso, decimal deduccion, string pais) {
        decimal ti = ingreso - deduccion;
        if (_estrategias.ContainsKey(pais)) {
            return _estrategias[pais].CalculateTax(ti);
        }
        return 0; 
    }
}