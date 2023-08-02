unit UCNatural;

interface
uses math;

  Type Natural = Class
    private
      Value:Cardinal;
    public
      constructor Create;
      procedure setValue(v:Cardinal);
      function getValue:Cardinal;
      procedure insDigit(posicion,digito:Byte);
      function getDigit(posicion:Byte):Byte;
      procedure delDigitV1(posicion:byte);
      Procedure delDigitV2(digito:Byte);
      Procedure delDigitV3(digito,cantidad:integer);
      Function numDigits:Byte;
      Function sumDigits:Byte;
      Function numParDigits:Byte;
      Function numImparDigits:Byte;
      Function numPrimoDigits:Byte;
      Function mayDigit: Byte;
      Function menDigit:Byte;
      Procedure InvertirNumero();
      Function EsCapicua:Boolean;
      Function EsPrimo:Boolean;
      Function ToBaseN(Base:Byte):String;  // convierte a base 35
      Function ToRomano:String;
      Function ToLiteral:String;   // convierte a literal 23= veinte y tres
      Function esPar:Boolean;

      //insertar digito al inicio de la izquierda
      // 56123 3956123
      procedure insDigitLeft(digito:integer;var expo:Byte; nd:Byte);

      // 4556 455623
      procedure insDigitRigth(digito:integer);
      Procedure EliminarRepetidos;

      //cantidad derepitaciones de un numero dentro del numero
      // 212122313212 212 3
      Function FrecuenciaDigito(numero,nd:integer):Byte;
      Procedure ConstruirUnicosConRepetidos;
      Procedure delDigitsNoPrimos;
      Function digitoPrimoMayor:Byte;
      Function posDigit(digito:Byte):Byte;
      Procedure OrdenarAscendentemente;
      Procedure OrdenarDescendentemente;
      procedure unirNumeros(numero:Cardinal);
      Procedure segmentarPrimo_NoPrimoV1;
      Procedure segmentarPrimo_NoPrimoV2;
      Procedure segmentarOrdenadoPrimoAscendente_OrdenadoNoPrimoDescendente;
      Function mayorAgrupado(agrupacion:Byte):Cardinal;
      Function digitoMasRepetido:Byte;
      procedure delDigitMasRepetido;
      //35235842 -> 352842 eliminar de a N digitos dejando solo una aparicion
      procedure preg1NN(numero:Cardinal);
      procedure preg2NN;

      //semestre 2/2021
      //eliminar numero ejercicio josue
      function frecuenciaV2(N:Cardinal):Byte;
      procedure eliminar_numero(F:Cardinal);
      function sacar_numero(cant:Byte):Cardinal;
      procedure cortar_numero(cant:Byte);

      //PREGUNTA 1 GRUPO-SH NUMEROS NATURALES 2/2021
    //eliminar los DOS digitos mas repetidos
    // 200156440 y devuelva
    // 201564

    FUNction frecuenciaDig(d:byte):byte;
    function digitoMasRepe:byte;
    procedure elimDigitos(d,frec:byte);
    procedure ElimLos2DigMasPere;
  End;

implementation

{ Natural }


constructor Natural.Create;
begin
  Value := 0;
end;


Function Natural.posDigit(digito:Byte):Byte;
var contador,dig,posicion:Byte;
    numero:Cardinal;
begin
numero:=value;
contador:=0;
posicion:=0;

  while numero>0 do
  begin
    dig:=numero mod 10;
    contador:=contador+1;
    if dig=digito then
    begin
      posicion:=contador;
      break;
    end;
    numero := numero div 10;
  end;
  result:=posicion;
end;


procedure Natural.preg1NN(numero: Cardinal);
var bob:Natural;
    agrupar, digitos:Cardinal;
    nd,c,p:Byte;
begin
  bob:=Natural.Create;
  bob.setValue(numero);
  nd := bob.numDigits;
  bob.setValue(0);
  c:=FrecuenciaDigito(numero,nd)-1;
  p:=0;
  agrupar:=Trunc(power(10,nd)) ;
  if agrupar=1 then begin
    agrupar:=10;
  end;
  while value>0 do begin
    digitos:=value mod agrupar;
    if (digitos=numero) and (c>0) then begin
      value := value div agrupar;
      c:=c-1;
    end
    else begin
      digitos := digitos mod 10;
      bob.insDigitLeft(digitos,p,1);
      value := value div 10;
    end;
  end;
  value := bob.getValue;
end;


procedure Natural.preg2NN;
var dig:Byte;
    paco:Boolean;
    A,Pot:Cardinal;
begin
  paco:=true;
  Pot:=1;
  A:=0;
  while value>0 do
  begin
    dig := menDigit;
    if paco then
    begin
      A:=A*10+dig;
      paco:=false;
    end
    else
    begin
      A:=A+pot*dig;
      paco:=true;
    end;
    pot:=pot*10;
    delDigitV3(dig,1);
  end;
  value:=A;
end;

Procedure Natural.OrdenarAscendentemente;
var digito:Integer;
  bob:Natural;
begin
  bob:=Natural.Create;
  while value>0 do
  begin
    digito:=menDigit;
    bob.insDigitRigth(digito);
    delDigitV3(digito,1);
  end;
  value:=bob.getValue;
end;


Procedure Natural.OrdenarDescendentemente;
var posicion_digitoMenor,digito:Integer;
    ayuco:Natural;
    p:Byte;
begin
  p:=0;
  ayuco:=Natural.Create;
  while value>0 do
  begin
    digito:=menDigit;
    ayuco.insDigitLeft(digito,p,1);
    posicion_digitoMenor:=posDigit(digito);
    delDigitV1(posicion_digitoMenor);
  end;
  value:=ayuco.getValue;
end;




procedure Natural.segmentarOrdenadoPrimoAscendente_OrdenadoNoPrimoDescendente;
var digito,p,q:Byte;
    A,B:Natural;
begin
A:=Natural.Create;
B:=Natural.Create;
p:=0;
q:=0;
  while Value>0 do
  begin
    digito := getDigit(1);
    if digito in [1,2,3,5,7] then
    begin
      A.insDigitLeft(digito,p,1);
    end
    else
    begin
      B.insDigitLeft(digito,q,1);
    end;
    delDigitV1(1);
  end;
  A.OrdenarAscendentemente;
  B.OrdenarDescendentemente;
  B.unirNumeros(A.getValue);
  value := B.getValue;
end;

procedure Natural.segmentarPrimo_NoPrimoV1;
var digito,p:Byte;
    bob:Natural;
begin
bob:=Natural.Create;
p:=0;
  while Value>0 do
  begin
    digito := getDigit(1);
    if digito in [1,2,3,5,7] then
    begin
    bob.insDigitLeft(digito,p,1);
    end
    else
    begin
    bob.insDigitRigth(digito);
    end;
    delDigitV1(1);
  end;
  value := bob.getValue;
end;

procedure Natural.segmentarPrimo_NoPrimoV2;
var digito,p,q:Byte;
    A,B:Natural;
begin
A:=Natural.Create;
B:=Natural.Create;
p:=0;
q:=0;
  while Value>0 do
  begin
    digito := getDigit(1);
    if digito in [1,2,3,5,7] then
    begin
      A.insDigitLeft(digito,p,1);
    end
    else
    begin
      B.insDigitLeft(digito,q,1);
    end;
    delDigitV1(1);
  end;
  B.unirNumeros(A.getValue);
  //unirNumeros(B.getValue);
 // unirNumeros(A.getValue);
  value := B.getValue;
end;

procedure Natural.setValue(v: Cardinal);
begin
  Value := v;
end;


function Natural.getValue: Cardinal;
begin
  result:=Value;
end;


Function Natural.FrecuenciaDigito(numero, nd:integer):Byte;
var contador,dig:Byte;
    copia,agrupar:Cardinal;
begin
  copia:=value;
  contador:=0;
  agrupar := Trunc( power(10,nd) );
  if agrupar=1 then
  begin
    agrupar:=10;
  end;

  while copia>0 do  begin
    dig := copia mod agrupar;
    if dig = numero then   begin
      Inc(contador);
    end;
    copia := copia div 10;
  end;
  result:=contador;
end;



Procedure Natural.EliminarRepetidos;
var digito,frecuencia,p:Byte;
    construir:Natural;
begin
Construir:= Natural.Create;
p:=0;
  while value > 0 do
  begin
    digito :=  getDigit(1);
    frecuencia:=FrecuenciaDigito(digito,1);
    if frecuencia>1 then
    begin
      delDigitV2(digito);
    end
    else
    begin
      Construir.insDigitLeft(digito,p,1);
      delDigitV1(1);
    end;
  end;
  value:=construir.getValue;

end;




procedure Natural.unirNumeros(numero:Cardinal);
var cantidad:Byte;
begin
cantidad:=numDigits;
value := numero * Trunc(power(10,cantidad)) + value;
end;


procedure Natural.insDigitLeft(digito:integer; var expo:Byte; nd:Byte);
begin
value := digito * Trunc(power(10,expo))+value;
expo:=expo + nd ;
end;

procedure Natural.insDigitRigth(digito: integer);
begin
value := value *10 + digito;
end;

Procedure Natural.delDigitV3(digito,cantidad:integer);
var dig:integer;
    construir:Natural;
    p:Byte;

    pot,A:Cardinal;
begin
 // construir:= Natural.Create;
 // p:=0;
  pot:=1;
  A:=0;

  while value >0 do
  begin
    dig := value mod 10;
    if (dig=digito) and (cantidad>0) then
    begin
      dec(cantidad);
    end
    else
    begin
      A:=dig*pot+A; //A+pot*dig
      pot:=pot*10;
     // construir.insDigitLeft(dig,p,1);
    end;
    value := value div 10;
  end;
  value:=A;//construir.getValue;
end;





function Natural.digitoMasRepe: byte;
var antfrec,actfrec,actdig,antdig:byte;
    copia:Cardinal;
begin
antdig := value mod 10;
antfrec := frecuenciaDig(antdig);
copia := value;

  while copia>0 do
  begin
    actdig := copia mod 10;
    actfrec := frecuenciaDig(actdig);
    if actfrec > antfrec then
    begin
      antfrec := actfrec;
      antdig := actdig;
    end;
    copia := copia div 10;
  end;
  result := antdig;
end;

function Natural.digitoMasRepetido: Byte;
var numero:Natural;
    mayorDigito,mayorFrecuencia,digito,frecuencia:Byte;
begin
numero:=Natural.Create;
numero.setValue(value);
mayorDigito:= numero.getValue mod 10;
mayorFrecuencia:=FrecuenciaDigito(mayorDigito,1);
  while numero.getValue>0 do
  begin
    digito := numero.getValue mod 10;
    frecuencia := FrecuenciaDigito(digito,1);
    if frecuencia>mayorFrecuencia then
    begin
      mayorDigito:=digito;
      mayorFrecuencia:=frecuencia;
    end;
    numero.delDigitV2(digito);
  end;
  result:=mayorDigito;
end;

function Natural.digitoPrimoMayor: Byte;
var auxiliar:Natural;
begin
auxiliar:=Natural.Create;
auxiliar.setValue(value);
auxiliar.delDigitsNoPrimos;
result := auxiliar.mayDigit;
end;

procedure Natural.elimDigitos(d, frec: byte);
var dig:byte;
    bob,p:Cardinal;
begin
  bob:=0;
  p:=1;
  while value>0 do
  begin
    dig := value mod 10;
    if dig = d then
    begin
      if frec=1 then
      begin
        bob := dig * p + bob;
        p:=p*10;
      end
      else
      begin
        frec:=frec -1;
      end;
    end
    else
    begin
      bob := dig * p + bob;
      p:=p*10;
    end;

    value := value div 10;
  end;
   value := bob;
end;

procedure Natural.insDigit(posicion, digito: Byte);
var
    construir:Natural;
    dig,p,contador:byte;
begin
construir:=Natural.Create;
contador:=0;
p:=0;
  while (Value>0) do
  begin
    dig:= Value mod 10;
    contador:= contador + 1;
    if contador=posicion then
    begin
      construir.insDigitLeft(digito,p,1);
    end;
    construir.insDigitLeft(dig,p,1);
    Value:=Value div 10;
  end;
  Value:=construir.getValue;
end;



function Natural.getDigit(posicion: Byte): Byte;
var
    contador,digito,guardar:byte;
    copia:Cardinal;
begin
  copia:=Value;
  contador:=0;
  while copia>0 do
  begin
    digito:=copia mod 10;
    contador := contador + 1;
    if contador = posicion then
    begin
      guardar := digito;
    end;
    copia:=copia div 10;
  end;
  result:=guardar;
end;

procedure Natural.delDigitMasRepetido;
var digito:Byte;
begin
digito := digitoMasRepetido;
delDigitV2(digito);
end;

procedure Natural.delDigitsNoPrimos;
var digito,p:Byte;
    bob:Natural;
begin
bob := Natural.Create;
p:=0;
  while value>0 do
  begin
    digito := getDigit(1);
    if digito in [1,2,3,5,7] then
    begin
      bob.insDigitLeft(digito,p,1);
    end;
    delDigitV1(1);
  end;
  value := bob.getValue;
end;

procedure Natural.delDigitV1(posicion: byte);
var contador,digito,p:Byte;
   construir:Natural;
begin
  construir:=Natural.Create;
  contador:=0;
  p:=0;
  while Value>0 do
  begin
    digito:= getDigit(1);
    Inc(contador);
    if contador<>posicion then
    begin
      construir.insDigitLeft(digito,p,1);
    end;
    Value := value div 10 ;
  end;
  Value:=construir.getValue;
end;

procedure Natural.delDigitV2(digito: Byte);
var dig,p:byte;
    construir:Natural;
begin
  construir := Natural.Create;
  p:=0;
  while Value>0 do
  begin
    dig:=getDigit(1);
    if dig<>digito then
    begin
      construir.insDigitLeft(dig,p,1);
    end;
    delDigitV1(1);
  end;
  Value := construir.getValue;
end;

function Natural.numDigits: Byte;
var contador:Byte;
    N:Cardinal;
begin
contador := 0;
  if value>0 then
    contador := Trunc(Log10(value))+1;
  result := contador;
end;

function Natural.sumDigits: Byte;
var digito:Byte;
    suma:Word;
    copia:Cardinal;
begin
  copia:=Value;
  suma:= 0;
  while copia>0 do
  begin
    digito := copia mod 10;
    suma:=suma + digito;
    copia := copia div 10;
  end;
  result:=suma;
end;


function Natural.numParDigits: Byte;
var c,d:byte;
    N:Cardinal;
begin
  N:=Value;
  c:=0;
  while n>0 do
  begin
    d:= N mod 10;
    if d mod 2 = 0 then
    begin
      inc(c);
    end;
    N := N div 10;
  end;
  result:=c;
end;


function Natural.numImparDigits: Byte;
var contador,digito:byte;
    copia:Cardinal;
begin
  copia:=Value;
  contador:=0;
  while copia>0 do
  begin
    digito:= copia mod 10;
    if digito mod 2 = 1 then
      INC(contador);
    copia := copia div 10;
  end;
  result:=contador;
end;

function Natural.numPrimoDigits: Byte;
var contador,digito:byte;
    copia:Cardinal;
begin
  copia:=Value;
  contador:=0;
  while copia>0 do
  begin
    digito:= copia mod 10;
    if digito in [1,2,3,5,7] then
    begin
      contador:=contador+1;
    end;
    copia := copia div 10;
  end;
  result:=contador;
end;


function Natural.mayDigit: Byte;
var mayor,digito:byte;
    copia:Cardinal;
begin
  copia:=Value;
  mayor := copia mod 10;
  while copia>0 do
  begin
    digito:= copia mod 10 ;
    if digito > mayor then
    begin
      mayor := digito;
    end;
    copia := copia div 10;
  end;
  mayDigit:=mayor;
end;

function Natural.mayorAgrupado(agrupacion:Byte): Cardinal;
var numero,mayor,agrupar:Cardinal;
    digitos:Natural;
begin
digitos:=Natural.Create;
numero := value;
mayor := numero mod 100;
agrupar := Trunc(power(10,agrupacion));
  while numero>0 do
  begin
    digitos.setValue(numero mod agrupar);
    if digitos.getValue>mayor then
    begin
      mayor:=digitos.getValue;
    end;
    digitos.InvertirNumero;
    if digitos.getValue>mayor then
    begin
      mayor:=digitos.getValue;
    end;
    numero := numero div 10;
  end;
  result := mayor;
end;

function Natural.menDigit: Byte;
var menor,digito:byte;
    copia:Cardinal;
begin
  copia:=Value;
  menor := copia mod 10;

  while copia>0 do
  begin
    digito:= copia mod 10;
    if digito < menor then
    begin
      menor := digito;
    end;
    copia := copia div 10;
  end;
  result:=menor;
end;

procedure Natural.InvertirNumero;
var digito:Byte;
    construir:Natural;
begin
  construir:=Natural.Create;
  while Value>0 do
  begin
    digito:=getDigit(1);
    construir.insDigitRigth(digito);
    delDigitV1(1);
  end;
  Value:=construir.getValue;
end;


procedure Natural.ElimLos2DigMasPere;
var I,dig,frec:Byte;

begin
  for I := 1 to 2 do
  begin
    if value>0 then
    begin
      dig := digitoMasRepe;
      frec := frecuenciaDig(dig);
      elimDigitos(dig,frec);
    end;
  end;

end;

function Natural.EsCapicua: Boolean;
var copia:Cardinal;

begin
copia:=Value;
InvertirNumero;
result:=copia=Value;
end;




function Natural.esPar: Boolean;
begin
result := value mod 2 = 0;
end;

function Natural.EsPrimo: Boolean;
var paco:boolean;
    N,i:Cardinal;
begin
N:=Value;
i:=2;
paco:=true;
  while (i<n) and (paco) do
  begin
    if (n mod i) = 0 then
    begin
      paco:=false;
    end;
    i:=i+1;
  end;
  result:=paco;
end;



function Natural.frecuenciaDig(d: byte): byte;
var c,dig:byte;
    copia:Cardinal;
begin
c := 0;
copia := value;
  while copia>0 do
  begin
    dig := copia mod 10;
    if dig = d then
    begin
      c:=c+1;
    end;
    copia := copia div 10;
  end;
  result := c;
end;

function Natural.ToBaseN(Base:Byte): String;
var N:Cardinal;
    res:Byte;
    Resultado,alfabeto:String;
begin
N:=Value;
alfabeto:='0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ';
Resultado:='';
  while N>0 do
  begin
    res:= N mod base;
    N := N div base;
    Resultado := alfabeto[res+1] + Resultado;    //construccion
  end;
  result := Resultado;
end;

function Natural.ToRomano: String;

Const romanos: array[1..4,1..9] of String =
  (
   ('I','II','III','IV','V','VI','VII','VIII','IX'),
   ('X','XX','XXX','XL','L','LX','LXX','LXXX','XC'),
   ('C','CC','CCC','CD','D','DC','DCC','DCCC','CM'),
   ('M','MM','MM','Mv','v','vi','vii','viii','ix')
  );
var   d,c:Byte;
   N:Cardinal;
   Rom:String;
begin
N:=Value;
Rom:='';
c:=1;
  while N>0 do
  begin
    d:=N mod 10;
    if d>0 then
    begin
      Rom:= romanos[c,d]+ Rom;
    end;
    Inc(c);
    N := N div 10;
  end;
  result := Rom;
end;

function Natural.ToLiteral: String;
Const Lit : Array[1..4,1..20] of String=
(
('Uno','Dos','Tres','Cuatro','Cinco','Seis','Siete','Ocho','Nueve','Diez','Once','Doce','Trece','Catorce','Quince','Dieciseis','Diecisiete','Dieciocho','Diecinueve','Veinte'),
('','Veinti','Treinta','Cuarenta','Cincuenta','Secenta','Setenta','Ochenta','Noventa','','','','','','','','','','',''),
('Ciento', 'Doscientos', 'Trescientos', 'Cuatrocientos', 'Quinientos', 'Seiscientos', 'Setecientos', 'Ochocientos', 'Novecientos','','','','','','','','','','','' ),
('Mil','Dos Mil','Tres Mil', 'Cuatro Mil','Cinco Mil','Seis Mil', 'Siete Mil','Ocho Mil', 'Nueve Mil','','','','','','','','','','','')
);
var Literal:String;
    c,d:Byte;
    N:Cardinal;
begin
  N:=Value;
  c:=1;
  Literal:='';


  if N=100 then
  begin
    Literal := 'Cien' ;
    N:=0;
  end
  else
  begin

    if (N mod 100>0) and (N mod 100 <= 20 ) then
    begin
    Literal := Lit[1,N mod 100] ;
    N:=N div 100;
    c:=3;
    end;
  end;



  while N>0 do
  begin
    d := N mod 10;
    if d>0 then
    begin
      if (c=2) and (d>2) then
      begin
      Literal := 'y '+ Literal;
      end;
      Literal :=  Lit[c,d]  + ' '+ Literal;
    end;
    Inc(c);
    N:=N div 10;
  end;


  if Literal[Length(Literal)] = ' ' then
  begin
    Delete(Literal,Length(Literal),1);
  end;

  result:=Literal;
end;


Procedure Natural.ConstruirUnicosConRepetidos;
var digito,frecuencia:integer;
    construir:Natural;
    p:Byte;
begin
construir:= Natural.Create;
p:=0;
  while value>0 do
  begin
    digito:=getDigit(1);
    frecuencia:=FrecuenciaDigito(digito,1);
      if frecuencia>1 then
      begin
        construir.insDigitLeft(digito,p,1);
      end;
      delDigitV2(digito);
  end;
  value:=construir.getValue;
end;



function Natural.sacar_numero(cant: Byte): Cardinal;
var numero,copia:Cardinal;
begin
  copia := value;
  numero:=copia mod Trunc(power(10,cant));
  result:=numero;
end;


procedure Natural.cortar_numero(cant: Byte);
begin
value:=value div Trunc(power(10,cant));
end;


function Natural.frecuenciaV2(N: Cardinal): Byte;
var copia,num:Cardinal;
    C,cant:Byte;
    copy:Natural;
    auxiliar:Natural;
begin
copia:=value;
C:=0;
auxiliar:=Natural.Create;
auxiliar.setValue(N);
cant:=auxiliar.numDigits;

copy:=Natural.Create;
copy.setValue( value );


//despues
  while copy.getValue>0 do
  begin
    num:=copy.sacar_numero(cant);
    if num=N then
    begin
      c:=c+1;
    end;
    copy.cortar_numero(1);
  end;
  result:=c;



//antes
 { while copia>0 do
  begin
    num:=copia mod 100; //modificar para varios digitos
    if num=N then
    begin
      c:=c+1;
    end;
    COPIA:=COPIA div 10;
  end; }

  //result:=c;
end;


procedure Natural.eliminar_numero(F: Cardinal);
var bob,p,numero:Cardinal;
    dig,frec,cant:byte;
    auxiliar:Natural;
begin
auxiliar:=Natural.Create;
bob:=0;
p:=1;
frec:=frecuenciaV2(F);
auxiliar.setValue(F);
cant:=auxiliar.numDigits;
      while value>0 do
      begin
        numero:= sacar_numero(cant);
        if numero=F then
        begin
          if frec>1 then
          begin
            cortar_numero(cant);
            frec:=frec-1;
          end
          else
          begin
            dig:=numero mod 10;
            bob:= bob+dig*p;
            p:=p*10;
            cortar_numero(1)
          end;
        end
        else
        begin
          dig:=numero mod 10;
          bob:= bob+dig*p;
          p:=p*10;
          cortar_numero(1)
        end;

      end;
  value:=bob;
end;



end.


