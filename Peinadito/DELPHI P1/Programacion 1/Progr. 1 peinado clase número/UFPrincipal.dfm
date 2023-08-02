object frmPrincipal: TfrmPrincipal
  Left = 0
  Top = 0
  Caption = 'N UMEROS'
  ClientHeight = 452
  ClientWidth = 589
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 120
    Top = 88
    Width = 31
    Height = 13
    Caption = 'Label1'
  end
  object Edit1: TEdit
    Left = 120
    Top = 32
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object Button1: TButton
    Left = 296
    Top = 30
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 1
  end
  object MainMenu1: TMainMenu
    Left = 368
    Top = 224
    object Metodos1: TMenuItem
      Caption = 'Metodos'
      object Metodos2: TMenuItem
        Caption = 'Cambiar Valor'
        OnClick = Metodos2Click
      end
      object ObtenerValor1: TMenuItem
        Caption = 'Obtener Valor'
        OnClick = ObtenerValor1Click
      end
      object ObtenerValor2: TMenuItem
        Caption = 'Sumar Digitos'
        OnClick = ObtenerValor2Click
      end
      object Romanos1: TMenuItem
        Caption = 'Romanos'
        OnClick = Romanos1Click
      end
    end
  end
end
