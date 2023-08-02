program Proyectito;

uses
  Vcl.Forms,
  UFPrincipal in 'UFPrincipal.pas' {Form1},
  UCnumber in 'UCnumber.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
