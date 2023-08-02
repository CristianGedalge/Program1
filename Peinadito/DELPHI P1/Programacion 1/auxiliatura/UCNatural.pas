unit UCNatural;

interface
uses math;

type
    NATURAL = class   //clase
      private
          valor:cardinal;    //atributo

      public
          procedure setvalor(v:cardinal);      //metodos
          function getValor:cardinal;
          function EsCapicua:boolean;

      end;

implementation

{ NATURAL }

function NATURAL.EsCapicua: boolean;
var copia:natural;
begin
    copia := natural.crear(valor);
    copia.invertir


end;

function NATURAL.getValor: cardinal;
begin
    result := valor;

end;

procedure NATURAL.setvalor(v: cardinal);
begin
    valor := v;

end;

end.
