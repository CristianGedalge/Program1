unit UPFormulario;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    MainMenu1: TMainMenu;
    Metodos1: TMenuItem;
    AdicionarCadena1: TMenuItem;
    ObtenerCadena1: TMenuItem;
    Longituddelacadena1: TMenuItem;

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}



end.
