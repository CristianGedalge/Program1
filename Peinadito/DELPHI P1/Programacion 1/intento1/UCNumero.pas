unit UCNumero;

interface
uses math,sysutils;

type
  numeros = class
    private
     value:cardinal;


    public
     procedure SetValue(v:cardinal);
     procedure ElimDig(p:byte);
     function GetValue:cardinal;
     function ContPares:byte;
     function CantDig:byte;
     function OrdeDeAdentrHacAfuera:cardinal;
     function MenorDigNum:byte;
  end;

implementation

{ numeros }

function numeros.CantDig: byte;
begin
  if (value=0) then begin
    result:=1;
  end else begin
    result:= trunc(log10(value))+1;
  end;
end;

function numeros.ContPares: byte;
var n:cardinal;
    r,c:byte;
begin
 n:= value;
 c:= 0;
 while n>0 do begin
   r:= n mod 10;
   n:= n div 10;
   if ((r mod 2)=0) then begin
     c:= c + 1;
   end;
 end;
 result:= c;

end;

procedure numeros.ElimDig(p: byte);
var po,des:cardinal;
begin
 Po:= trunc(power(10,p-1));
 des:= value mod po;
 value:= value div po;
 value:= (value div 10)*po+des;


end;

function numeros.GetValue: cardinal;
begin
  result:=value;
end;

function numeros.MenorDigNum: byte;
var n:cardinal;
    r,r1:byte;
begin
  n:= value;
  r1:=9;
  while n>0 do begin
    r:= n mod 10;
    n:= n div 10;                     //210
    if r<=r1 then begin
      r1:=r;
    end;
  end;
  result:=r1;
end;

function numeros.OrdeDeAdentrHacAfuera: cardinal;
var copia:cardinal;
    nu,cd,r1,c:byte;
    drl:boolean;

begin
  copia:= value;
  cd:= CantDig;
  drl:=true;
  while cd<>0 do begin
   while  (copia>0) do begin
      r:= copia mod 10;
      copia:= copia div 10;
      if r<=r then  begin
        r1:=r
      end;
   end;

   repeat
    r1:= copia1 mod 10;
    copia1:= copia1 div 10;
    c:=c+1;
   until r1=c;

   pot:= trunc(power(10,c-1));
   r2:= copia2 mod pot;
   copia2:= copia2 div pot;
   copia2:= copia2 div 10;
   res:=copia*pot+ r2;

   if drl then begin
     der:= r*10;
     cd:=cd:+1;
   end else begin
     izq:= r+10;

   end;
  end;
  resf:=izq*trunc(power(10,cd))+der;

end;

procedure numeros.SetValue(v: cardinal);
begin
  value:=v;

end;

end.
