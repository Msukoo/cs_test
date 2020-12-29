using System;
using System.Collections.Generic;
using System.Text;

enum BLOCKDIR
{
    L,
    T,
    R,
    B,
}
enum BlOCKTYPE
{
    BT_I, //짝대기
    BT_L, //오른쪽갈고리
    BT_J, //왼쪽갈고리
    BT_Z, //내리막 계단
    BT_S, //오르막 계단
    BT_T, //T
    BT_O, //네모
}
partial class Block
{
    int X = 0;
    int Y = 0;
    List<List<string>> BlockData = new List<List<string>>();

    TetrisScreen screen = null;

    public Block(TetrisScreen _screen)
    {
        screen = _screen;
        for(int y=0; y<4; ++y)
        {
            BlockData.Add(new List<string>());
            
        }


    }

    private void Input()
    {
        if (true == Console.KeyAvailable)
        {
            return;
        }

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;
        }
    }

    public void Move()
    {      
        
        Input();
        screen.SetBlock(Y, X, "■");
        
    }
}


class TetrisScreen
{
    List<List<string>> BlockList = new List<List<string>>();
    public void SetBlock(int _y, int _x, string _type)
    {
        BlockList[_y][_x] = _type;
    }

    public void Clear()
    {
        for (int y = 0; y < BlockList.Count; y++)
        {
            for (int x = 0; x < BlockList[y].Count; x++)
            {
                if (y == 0 || y == BlockList.Count - 1)
                {
                    BlockList[y][x] = "▣";
                    continue;
                }
                BlockList[y][x] = "□";
            }
        }
    }
    public void Render()
    {
        for (int y = 0; y < BlockList.Count; y++)
        {
            for (int x = 0; x < BlockList[y].Count; x++)
            {
                //Console.Write("▣");
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }
    public TetrisScreen(int _X, int _Y)
    {

        for (int y = 0; y < _Y; ++y)
        {
            BlockList.Add(new List<string>());
            for (int x = 0; x < _X; ++x)
            {
                BlockList[y].Add("□");
            }

        }
        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = "▣";
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = "▣";
        }

    }
}
