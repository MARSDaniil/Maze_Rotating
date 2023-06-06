#         Maze Rotating

[Ссылка на рабочую версию на платформе YandexGame.](https://yandex.ru/games/app/223428?lang=ru)
[Ссылка на рабочую версию на платформе UnityPlay.](https://play.unity.com/mg/other/testbuild_0_0_1)
![Уровень 5](/README_Additional_materials/ezgif.com-optimize.gif) 
Это аркадная головоломка с процедурно генерируюемым лабиринтом и увеличением размера лабиринта с каждым уровнем, с целью повышения сложности прохождения.

![Уровень 10](/README_Additional_materials/MazeRotateLevel10.jpg)

Задачей игрока является провести шарик через лабиринт. В отличии от классических игр перемещения шарика, управление осуществляется через наклон лабиринта вокруг оси z. Таким образом шарик может лишь падать, под действием силы тяжести.

![Уровень 5](/README_Additional_materials/menu.jpg)

В игре реализованы, кроме сцен уровней, так же сцена меню, где есть графы info, setting и переход в level menu. Реализован система постепенного открытия уровней. 

![Уровень 5](/README_Additional_materials/cube.jpg) 

Так же в игре присутствуют 4 независимых, нестандартных уровня, которые открыты в любое время: Игра с перевернутой гравитацией, игра кубиком, вместо шара, игра, где цвет стенок и цвет и последним "странным уровнем" является уровень, где видны лишь ближайшие стенки и выход нужно искать вслепую.

![Уровень 5](/README_Additional_materials/crazyCamera.jpg) 

Алгоритм генерации лабиринта выполнен через стэк, который случайным образом проходит "сетку стенок(квадрат, состоящий из единичных квадратов)" и прокладывая маршрут случайным образом сетАктивит(фалсе) стенки, пока находит их. Когда же он не может это более делать - он возвращается на более раннюю позицию и пытается вырезать в той ячейки, и повторяет предыдущие действия. Таким образом генерируется проходы.

Функция прохода через стенки:
```
 private void RomoveWallWithBackTracker(MazeGeneratorCell[,] maze)//убирание лишних стен через стэк
    {
        MazeGeneratorCell current = maze[0, 0];
        current.Visited = true;
        Stack<MazeGeneratorCell> stack = new Stack<MazeGeneratorCell>();
        do
        {
            List<MazeGeneratorCell> unvisitedNeiborhood = new List<MazeGeneratorCell>();

            int x = current.X;
            int y = current.Y;
            if (x>0 && !maze[x-1, y].Visited)
            {
                unvisitedNeiborhood.Add(maze[x-1, y]);
            }
            if (y > 0 && !maze[x, y-1].Visited)
            {
                unvisitedNeiborhood.Add(maze[x , y-1]);
            }

            if (x < height - 2 && !maze[x+1, y ].Visited)
            {
                unvisitedNeiborhood.Add(maze[x+1, y]);
            }

            if (y < height -2  && !maze[x, y + 1].Visited)
            {
                unvisitedNeiborhood.Add(maze[x, y + 1]);
            }
            if(unvisitedNeiborhood.Count>0)
            {
                MazeGeneratorCell choosen = unvisitedNeiborhood[UnityEngine.Random.Range(0, unvisitedNeiborhood.Count)];
                RemoveWall(current, choosen);
                choosen.Visited = true;
                stack.Push(choosen);
                current = choosen;

            }
            else
            {
                
                    current = stack.Pop();
            }
        }
        while (stack.Count > 0);
    }
```
Функции удаления стен:
```
 private void RemoveWall(MazeGeneratorCell current, MazeGeneratorCell choosen)
    {
       if(current.X == choosen.X)
        {
            if(current.Y>choosen.Y)
            {
                current.wallBottom = false;
               
            }
            else
            {
                choosen.wallBottom = false;
            }
        }
       else
       {
            if (current.X > choosen.X)
            {
                current.wallLeft = false;

            }
            else
            {
                choosen.wallLeft = false;
            }
       }
    }
```