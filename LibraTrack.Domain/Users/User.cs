using LibraTrack.Domain.Users.Events;

namespace LibraTrack.Domain.Users;

public sealed class User : Entity<UserId>
{
    private User()
    {
    }

    private User(UserId id, FirstName firstName, LastName lastName, Email email, Gender gender) : base(id)
    {
        Email = email;
        Gender = gender;
        LastName = lastName;
        FirstName = firstName;
    }

    public Email Email { get; private set; }

    public Gender Gender { get; private set; }

    public LastName LastName { get; private set; }

    public FirstName FirstName { get; private set; }

    public string IdentityId { get; private set; } = string.Empty;

    public void SetIdentityId(string identityId)
    {
        IdentityId = identityId;
    }

    public static User Create(FirstName firstName, LastName lastName, Email email, Gender gender)
    {
        var user = new User(UserId.New(), firstName, lastName, email, gender);
        
        user.RaiseDomainEvent(new UserCreateDomainEvent(user.Id));

        return user;
    }
}