unit UCCadena;

interface
uses sysutils,math;

const
  MaxC= 2048;
type
  cadena = class
    private
      longitud:word;
      Caracteres:Array[1..MaxC] of char;


    public
      procedure AddStr(s:string);
      function ObtenerStr:string;
      function getLong:word;
      procedure addChar(c:char);
      function getChar(p:word):char;
      procedure modChar(p:word;c:char);
      procedure InsertChar(p:word;c:char);
      procedure Elimchar(p:word);

  end;

implementation

{ cadena }

procedure cadena.addChar(c: char);
begin
  Inc(longitud); //Longitud:=longitud + 1;
  Caracteres[longitud]:=c
end;

procedure cadena.AddStr(s: string);
var
  I:word;
begin
  Longitud:=length(s);
  for I := 1 to longitud do begin
    Caracteres[i]:=s[i];

  end;
end;

procedure cadena.Elimchar(p: word);
var
  I: Word;
begin
  if (p>0) and (p<=longitud) then begin

    for I := p to longitud-1 do begin
      Caracteres[P]:=caracteres[p+1];
    end;
    dec(longitud);
  end else raise Exception.Create('posicion invalida');

end;

function cadena.getChar(p: word): char;
begin
  if (p>0) and (p<= longitud)then begin
    result:=Caracteres[p];
  end else raise Exception.Create('posicion invalida');

end;

function cadena.getLong: word;
begin
  result:=Longitud;

end;

procedure cadena.InsertChar(p: word; c: char);
begin
  if (p>0) and (p<=longitud) then begin



  end else raise Exception.Create('posicion fuera de rango');

end;

procedure cadena.modChar(p: word; c: char);
begin

end;

function cadena.ObtenerStr: string;
begin

end;

end.
