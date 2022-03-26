public static class GeneradorISBN {
    // Atributo
    private static int contador = 0;
    
    // Métodos estáticos
    public static int nuevoID() {
        contador++;
        return contador;
    }
}