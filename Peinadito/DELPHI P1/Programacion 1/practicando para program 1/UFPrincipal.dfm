object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form'
  ClientHeight = 201
  ClientWidth = 447
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
    Left = 136
    Top = 64
    Width = 31
    Height = 13
    Caption = 'Label1'
  end
  object Edit1: TEdit
    Left = 88
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object MainMenu1: TMainMenu
    Top = 8
    object Metodos1: TMenuItem
      Caption = 'Metodos'
      object cambiarValor1: TMenuItem
        Caption = 'cambiarValor'
        OnClick = cambiarValor1Click
      end
      object ObtenerValor1: TMenuItem
        Caption = 'ObtenerValor'
        OnClick = ObtenerValor1Click
      end
      object SumadeDig1: TMenuItem
        Caption = 'SumadeDig'
        OnClick = SumadeDig1Click
      end
      object EliminarDig1: TMenuItem
        Caption = 'EliminarDig'
        OnClick = EliminarDig1Click
      end
    end
  end
end
