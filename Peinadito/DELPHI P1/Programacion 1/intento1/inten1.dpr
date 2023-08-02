program inten1;

uses
  Vcl.Forms,
  UPForm in 'UPForm.pas' {Formulario},
  UCNumero in 'UCNumero.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TFormulario, Formulario);
  Application.Run;
end.
