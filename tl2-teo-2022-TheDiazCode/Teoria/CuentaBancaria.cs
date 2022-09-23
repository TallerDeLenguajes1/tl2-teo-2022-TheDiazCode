namespace Cuenta;

public enum TipoExtraccion{
    CajeroHumano = 1,
    CajeroAutomatico = 2
}

public class CuentaBancaria{
    public int balance;

    //constructor
    public CuentaBancaria(){
        
    }

    // metodos
    public virtual void Insercion(int monto){

    }

    public virtual void Extraccion(int monto, TipoExtraccion tipo){

    }

}