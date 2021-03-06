﻿using Skeleton.Inter;
public class Hero:IHeros
{
    private string name;
    private int experience;
    private Axe weapon;

    public Hero(string name)
    {
        this.name = name;
        this.experience = 0;
        this.weapon = new Axe(10, 10);
    }

    public string Name
    {
        get { return this.name; }
    }

    public int Experience
    {
        get { return this.experience; }
    }

    public Axe Weapon
    {
        get { return this.weapon; }
    }

    public void Attack(ITargets target)
    {
        this.weapon.Attack(target);

        if (target.IsDead())
        {
            this.experience += target.GiveExperience();
        }
    }

    
}
