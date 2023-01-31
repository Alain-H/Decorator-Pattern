using Dekorator_Pattern;



    Auto my_Porsche_911 = new Porsche();

    my_Porsche_911 = new Ledersitze(my_Porsche_911);

    my_Porsche_911 = new Radio(my_Porsche_911);

    my_Porsche_911 = new Unterbodenbeleuchtung(my_Porsche_911);

    Console.WriteLine("Ihr Porsche ist {0} und kostet {1} Euro", my_Porsche_911.getAusstattung(), my_Porsche_911.getpreis());
    Console.WriteLine("---------------------------------------------------------------------------------------------------");






    Auto My_Audi = new Audi();

    My_Audi = new Ledersitze(My_Audi);

    My_Audi = new Radio(My_Audi);


    My_Audi = new Unterbodenbeleuchtung(My_Audi);

    Console.WriteLine("Ihr Audi ist {0} und kostet {1} Euro", My_Audi.getAusstattung(), My_Audi.getpreis());



    Console.ReadKey();



