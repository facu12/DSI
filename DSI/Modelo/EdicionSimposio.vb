Public Class EdicionSimposio Implements IAgregado 
    
    Property cantDiasParaCorrecciones As Integer
    Property fechaFin As Date
    Property fechaInicio As Date
    Property fechaLimitePresTrab As Date
    Property TrabajoDeInvestigacion[] TIs ;


    
    
    Public buscarTrabajoDeInvestigacion() As List(Of(TrabajoDeInvestigacion)
    {
      IIterador  itera = crearIterador(TIs);
        List <String> aux = New ArrayList();
        
        
        itera.primero();
   While (!itera.haTerminado()){
    TrabajoDeInvestigacion ti = (TrabajoDeInvestigacion) itera.actual();
	
		If (ti! = null){
			aux.add("Título de Trabajo de Investigación:" 
                        +ti.getTitulo() 
                       + "/n Número de Trabajo de Investigación:" 
                       + ti.getNroOrden());
}
		itera.siguiente(); 
}

                
        
        Return aux ;
    }

    @Override
    Public IIterador crearIterador(TrabajoDeInvestigacion[] elementos) 
    
{  
    IIterador iterador = New IteradorTIs(elementos);
	Return iterador;
}
    
  
   
    

    End Class
