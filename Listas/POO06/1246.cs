using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    while (string.IsNullOrEmpty(s) == false) {
      string[] vs = s.Split();
      int c = int.Parse(vs[0]); // Comprimento do estacionamento
      int n = int.Parse(vs[1]); // total de eventos
      int[] v = new int[c]
      int total = 0;
      for (int i = 0; i < n; i++) { // n eventos
        s = Console.ReadLine();    // cada evento
        vs = s.Split();            // dados de cada evento
        int p = int.Parse(vs[1]); // placa
        
        if (vs[0] == "C") {        // carro chegando
          int q = int.Parse(vs[2]); // comprimento
          int inicio = PodeEstacionar(v, q);
          if (inicio != -1) {
            Estacionar(v, q, p, inicio);
            total += 10;
          }
        }
        else {                     // carro saindo
            Sair(v, p);
        }
      }
      Console.WriteLine(total);
      s = Console.ReadLine();
    }
  }

  public static int PodeEstacionar(int[] v, int q, out int inicio) {
    // Tamanho do vetor = v.Length
    int tamVaga = 0;
    for (int i = 0; i < v.Length; i++) {
      if (v[i] == 0) tamVaga++; else tamVaga = 0;
      if (tamVaga == 0) return i - q + 1;
      }
    return -1;
    }
  }

  public static bool PodeEstacionar(int[] v, int q, out int inicio) {
  // Tamanho do vetor = v.Length
    int tamVaga = 0;
    for (int i = 0; i < v.Length; i++) {
      if (v[i] == 0) tamVaga++; else tamVaga = 0;
      if (tamVaga == 0) {
        inicio = i - q + 1;
        return true;
      }
    }
    inicio = 0;
    return false;
  }

  public static int Estacionar(int[] v, int q, int p, int incio) {
    for (int i = 0; i < q; i++) v[inicio + i] = p;
  }

  public static void Sair(int[] v, int p) {
    for (int i = 0; i < v.Length; i++)
      if (v[i] == p) v[i] = 0;
  }
}