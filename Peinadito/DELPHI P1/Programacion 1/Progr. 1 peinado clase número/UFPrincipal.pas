  unit UFPrincipal;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs,UCNumero, Vcl.Menus, Vcl.StdCtrls;

type
  TfrmPrincipal = class(TForm)
    MainMenu1: TMainMenu;
    Metodos1: TMenuItem;
    Metodos2: TMenuItem;
    ObtenerValor1: TMenuItem;
    ObtenerValor2: TMenuItem;
    Edit1: TEdit;
    Label1: TLabel;
    Button1: TButton;
    Romanos1: TMenuItem;
    procedure FormCreate(Sender: TObject);
    procedure Metodos2Click(Sender: TObject);
    procedure ObtenerValor1Click(Sender: TObject);
    procedure ObtenerValor2Click(Sender: TObject);
    procedure Romanos1Click(Sender: TObject);
  private
    { Private declarations }
    N :NumeroNatural;
  public
    { Public declarations }
  end;

var
  frmPrincipal: TfrmPrincipal;

implementation

{$R *.dfm}

procedure TfrmPrincipal.FormCreate(Sender: TObject);
begin
     N :=NumeroNatural.Create;

end;

procedure TfrmPrincipal.Metodos2Click(Sender: TObject);
begin
     N.setValor(StrToInt(Edit1.Text));
end;

procedure TfrmPrincipal.ObtenerValor1Click(Sender: TObject);
begin
     Label1.Caption:=IntToStr(N.getValor);
end;

procedure TfrmPrincipal.ObtenerValor2Click(Sender: TObject);
begin
     Label1.Caption:='La suma es:'+IntToStr(N.sumDigitos);
end;

procedure TfrmPrincipal.Romanos1Click(Sender: TObject);
begin
     Label1.Caption:=N.toRom;
end;

end.
