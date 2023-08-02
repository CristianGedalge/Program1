program Cadenas;

uses
  Vcl.Forms,
  UPFormulario in 'UPFormulario.pas' {Form1},
  UCCadena in 'UCCadena.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
