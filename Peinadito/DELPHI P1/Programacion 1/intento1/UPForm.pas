unit UPForm;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls,UCNumero;

type
  TFormulario = class(TForm)
    MainMenu1: TMainMenu;
    Button1: TButton;
    Button2: TButton;
    Edit2: TEdit;
    Metodos1: TMenuItem;
    ContadorPares1: TMenuItem;
    Edit1: TEdit;
    CantDigitos1: TMenuItem;
    ElimDigito1: TMenuItem;
    MenorDigito1: TMenuItem;
    procedure FormCreate(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure ContadorPares1Click(Sender: TObject);
    procedure CantDigitos1Click(Sender: TObject);
    procedure ElimDigito1Click(Sender: TObject);
    procedure MenorDigito1Click(Sender: TObject);
  private
    { Private declarations }
    valueaux:numeros;
  public
    { Public declarations }
  end;

var
  Formulario: TFormulario;

implementation

{$R *.dfm}

procedure TFormulario.Button1Click(Sender: TObject);
begin
 valueaux.SetValue(StrToInt(Edit1.text));
end;

procedure TFormulario.Button2Click(Sender: TObject);
begin
  Edit2.text := IntToStr(valueaux.GetValue);

end;

procedure TFormulario.CantDigitos1Click(Sender: TObject);
begin
  edit2.text := IntToStr(valueaux.CantDig);

end;

procedure TFormulario.ContadorPares1Click(Sender: TObject);
begin
  edit2.text:= IntTostr(valueaux.ContPares);

end;

procedure TFormulario.ElimDigito1Click(Sender: TObject);
begin
    valueaux.ElimDig(StrToInt(edit1.text));
end;

procedure TFormulario.FormCreate(Sender: TObject);
begin
   valueaux:=numeros.create;

end;

procedure TFormulario.MenorDigito1Click(Sender: TObject);
begin
   edit2.text:= IntToStr(valueaux.MenorDigNum);
end;

end.
