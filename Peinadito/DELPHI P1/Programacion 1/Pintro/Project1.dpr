program Project1;
var x,y:string;
    c:char;
    i,n:byte;
    begin
    write('Escriba un texto: ');
    readln(x);
    n := length(x);
    writeln(n);
    y := copy(x,7,4);
    writeln(y);
    delete(x,6,5);
    writeln(x);
    insert(' lola',x,6);

    writeln(x);
    i := pos('ola',x);
    writeln(i);
    c := x[3];
    writeln(c);
    x[2] := 'H'  ;
    writeln(x);
    x[3] := upcase(x[3]);
    writeln(x);
    readln;
    end.



