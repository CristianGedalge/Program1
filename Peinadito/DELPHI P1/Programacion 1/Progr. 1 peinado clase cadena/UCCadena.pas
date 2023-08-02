unit UCCadena;

interface

uses SysUtils;
  const
    MaxC=2048;
    Separador=[' ',',',';','-'];
    Alfa=['A'..'Z'];
    Numeric=['0'..'9',','];
    Vocal=['A','E','I','O','U'];

Type
    Cadena = Class
      Private
             Longitud :Word;
             Caracteres : Array[1..MaxC] Of Char;
      Public
            Function Long : Word;
            Procedure AddChar(C:Char);
            Procedure ModChar(P:Word;C:Char);
            Procedure InsChar(P:Word;C:Char);
            Procedure DelChar(P:Word);
            Function getChar(P:Word):Char;
            Procedure setStr(S:String);
            Function getStr:String;
            Function CountWord:Word;
            Function SigPalabra(var t  : Word):String;
            function SigNum(var i:word):string;
            Function PalMayLong:String;
            Function ContPalTerVocal:Word;
            function NumeroConDecimalMayor:real;

    End;

implementation

{ Cadena }

procedure Cadena.AddChar(C: Char);
begin
     Inc(Longitud);
     Caracteres[Longitud]:=C;
end;

function Cadena.ContPalTerVocal: Word;
Var
    i,c: Word;
    p: String;
begin
     i:=1;c:=0;
     while i<=Longitud do
     Begin
          p:=SigPalabra(i);
          if Upcase(p[length(p)]) in Vocal then
            c:=c+1;
     End;
     Result:=c;
end;

function Cadena.CountWord: Word;
Var
    i,c :Word;
begin
     i:=1; c:=0;
     while i<Longitud do
     Begin
          if not( Caracteres[i] in Separador) And (Caracteres[i+1] in Separador) then
             c:=c+1;
          i:=i+1;
     End;
      if not( Caracteres[i] in Separador) Then c:=c+1;
     Result:=c;

end;

procedure Cadena.DelChar(P: Word);
var
  I: Word;
begin
     if (P>0) And (P<=Longitud) then
     Begin
        for I := P to Longitud-1 do
          Caracteres[i]:=Caracteres[i+1];
         Dec(Longitud);
     End
     Else raise Exception.Create('Error Posicion invalida');
end;

function Cadena.getChar(P: Word): Char;
begin
     if (P>0) And (P<=Longitud) then
     Begin
           Result:=Caracteres[p];
     End
     Else raise Exception.Create('Error Posicion invalida');

end;

function Cadena.getStr: String;
Var
    i : Word;
    s : String;
begin
     s:='';
     for I := 1 to Longitud do
        s:=s+Caracteres[i];
     Result:=s;
end;

procedure Cadena.InsChar(P: Word; C: Char);
var
  I: Word;
begin
     if (P>0) And (P<=Longitud) then
     Begin
         Inc(Longitud);
         for I := Longitud downto P+1 do begin
           Caracteres[i]:=Caracteres[i-1];
         end;
         caracteres[p]:=c;

     End
     Else raise Exception.Create('Error Posicion invalida');

end;

function Cadena.Long: Word;
begin
     Result:=Longitud;
end;

procedure Cadena.ModChar(P: Word; C: Char);
begin
     if (P>0) And (P<=Longitud) then
     Begin
         Caracteres[p]:=c;
     End
     Else raise Exception.Create('Error Posicion invalida');
end;

function Cadena.NumeroConDecimalMayor: real;
var i:word; p:string; mayor,rem:real; p1:integer;
begin
  i:=1;
  mayor:=0;
  while i<=Longitud do begin
    p:=SigNum(i);
    p1:=trunc(StrToFloat(p));
    rem:=StrToFloat(p)- p1;


    if (rem > mayor) then begin
      mayor:=rem;

    end;

  end;
  result:=mayor;

end;

function Cadena.PalMayLong: String;
Var
   i:Word;
   PalMay,p : String;
begin
     i:=1;
     PalMay:=SigPalabra(i);
     while i<=Longitud do
     Begin
          p:=SigPalabra(i);
          if Length(p)>Length(PalMay) then
              PalMay:=p
     End;
     Result:=PalMay;
end;



procedure Cadena.setStr(S: String);
Var
    i : Word;
begin
     Longitud:=Length(s);
     for I := 1 to Longitud do
        Caracteres[i]:=s[i];
end;

function Cadena.SigNum(var i: word): string;

var p:string;

begin
  while (i<=Longitud) and not(Caracteres[i]in numeric) do begin
    i:=i+1;
  end;
  p:='';
  while (i<=Longitud) and (Caracteres[i]in numeric) do begin
    p:=p+caracteres[i];
    i:=i+1;
  end;
  result:= p;


end;

function Cadena.SigPalabra(var t: Word): String;
Var
  p : String;
begin
       while (t<=Longitud)And(Caracteres[t] in Separador) do begin
            t:=t+1;
       end;
       p:='';
       while (t<=Longitud)And(not (Caracteres[t] in Separador)) do
       Begin
            p:=p+Caracteres[t];
            t:=t+1;
       End;
       Result:=p;
end;

end.
