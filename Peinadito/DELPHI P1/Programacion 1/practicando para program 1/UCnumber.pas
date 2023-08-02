unit UCnumber;

interface
uses math;
type
  numeros = class
    private
    valor :cardinal;
    public
    procedure cambiarvalor(v:cardinal);
    function  obtenerValor:cardinal;
    function sumaDigitos:byte;
    procedure EliminarDigitos(p:byte );
  end;


implementation

{ numeros }

procedure numeros.cambiarvalor(v: cardinal);
begin
valor:=v;
end;

procedure numeros.EliminarDigitos(p:byte);
var n,t,r:cardinal;
begin
t:= trunc(power(10,p-1));
r:= valor mod t;
n:= valor div t;
n:= n div 10;
valor:= n*t+r;

end;

function numeros.obtenerValor: cardinal;
begin
result:= valor;

end;

function numeros.sumaDigitos: byte;
var r,s:byte;
    n:cardinal;
begin
    n:=valor;
    s:=0;
    while n>0  do
    begin
      r:= n mod 10;
      s:=s+r;
      n:= n div 10;

    end;
    result:= s;
end;

end.
