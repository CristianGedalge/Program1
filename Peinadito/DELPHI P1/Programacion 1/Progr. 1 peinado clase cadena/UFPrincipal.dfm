object frmPrincipal: TfrmPrincipal
  Left = 0
  Top = 0
  Caption = 'CADENAS'
  ClientHeight = 477
  ClientWidth = 652
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
    Left = 88
    Top = 176
    Width = 3
    Height = 13
  end
  object Edit1: TEdit
    Left = 88
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 88
    Top = 96
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object MainMenu1: TMainMenu
    Left = 8
    Top = 8
    object Metodos1: TMenuItem
      Caption = 'Metodos'
      object Metodos2: TMenuItem
        Caption = 'Longitud de la cadena'
        OnClick = Metodos2Click
      end
      object Adicionarcaracter1: TMenuItem
        Caption = 'Adicionar caracter'
        OnClick = Adicionarcaracter1Click
      end
      object Adicionarcaracter2: TMenuItem
        Caption = 'Modificar Caracter'
        OnClick = Adicionarcaracter2Click
      end
      object InsertarCaracter1: TMenuItem
        Caption = 'Insertar Caracter'
        OnClick = InsertarCaracter1Click
      end
      object InsertarCaracter2: TMenuItem
        Caption = 'Eliminar Caracter'
        OnClick = InsertarCaracter2Click
      end
      object ContarPalabras1: TMenuItem
        Caption = 'Contar Palabras'
        OnClick = ContarPalabras1Click
      end
      object ObtenerCadena1: TMenuItem
        Caption = 'Obtener Cadena'
        OnClick = ObtenerCadena1Click
      end
      object ObtenerCadena2: TMenuItem
        Caption = 'Adicionar Cadena'
        OnClick = ObtenerCadena2Click
      end
      object PalabraMayorLongitud1: TMenuItem
        Caption = 'Palabra Mayor Longitud'
        OnClick = PalabraMayorLongitud1Click
      end
      object Palabrasqueterminanenvocal1: TMenuItem
        Caption = 'Palabras que terminan en vocal'
        OnClick = Palabrasqueterminanenvocal1Click
      end
      object Mayor1: TMenuItem
        Caption = 'Mayor decimal de un numero'
        OnClick = Mayor1Click
      end
    end
  end
end
