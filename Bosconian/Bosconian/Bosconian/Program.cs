using System;

namespace Bosconian {
#if WINDOWS || XBOX
    static class Program {
        static void Main(string[] args) {
            using (Game game = new Game()) game.Run();
        }
    }
#endif
}

