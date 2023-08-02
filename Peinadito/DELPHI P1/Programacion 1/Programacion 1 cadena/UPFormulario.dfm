object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 221
  ClientWidth = 447
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 56
    Top = 112
    Width = 31
    Height = 13
    Caption = 'Label1'
  end
  object Edit1: TEdit
    Left = 56
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
  end
  object Edit2: TEdit
    Left = 56
    Top = 72
    Width = 121
    Height = 21
    TabOrder = 1
    Text = 'Edit2'
  end
  object MainMenu1: TMainMenu
    Left = 65528
    Top = 8
    object Metodos1: TMenuItem
      Caption = 'Metodos'
      object AdicionarCadena1: TMenuItem
        Caption = 'AdicionarCadena'
      end
      object ObtenerCadena1: TMenuItem
        Caption = 'ObtenerCadena'
      end
      object Longituddelacadena1: TMenuItem
        Caption = 'Longitud de la cadena'
      end
    end
  end
end
