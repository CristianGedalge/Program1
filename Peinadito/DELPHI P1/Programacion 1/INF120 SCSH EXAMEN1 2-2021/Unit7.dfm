object Form7: TForm7
  Left = 0
  Top = 0
  Caption = 'Form7'
  ClientHeight = 377
  ClientWidth = 288
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 64
    Top = 36
    Width = 47
    Height = 13
    Caption = 'ENTRADA'
  end
  object Label2: TLabel
    Left = 75
    Top = 145
    Width = 36
    Height = 13
    Caption = 'SALIDA'
  end
  object Label3: TLabel
    Left = 529
    Top = 111
    Width = 6
    Height = 13
    Caption = 'd'
  end
  object Label4: TLabel
    Left = 568
    Top = 111
    Width = 19
    Height = 13
    Caption = 'frec'
  end
  object txtEntrada: TEdit
    Left = 32
    Top = 68
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object txtSalida: TEdit
    Left = 32
    Top = 164
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object Button1: TButton
    Left = 184
    Top = 68
    Width = 75
    Height = 25
    Caption = 'CARGAR'
    TabOrder = 2
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 184
    Top = 106
    Width = 75
    Height = 25
    Caption = 'MOSTRAR'
    TabOrder = 3
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 529
    Top = 22
    Width = 121
    Height = 25
    Caption = 'Digito mas repetido'
    TabOrder = 4
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 528
    Top = 53
    Width = 75
    Height = 25
    Caption = 'eliminar digitos'
    TabOrder = 5
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 528
    Top = 130
    Width = 75
    Height = 25
    Caption = 'PREGUNTA 1'
    TabOrder = 6
    OnClick = Button5Click
  end
  object Edit1: TEdit
    Left = 529
    Top = 84
    Width = 33
    Height = 21
    TabOrder = 7
  end
  object Edit2: TEdit
    Left = 568
    Top = 84
    Width = 35
    Height = 21
    TabOrder = 8
  end
end
