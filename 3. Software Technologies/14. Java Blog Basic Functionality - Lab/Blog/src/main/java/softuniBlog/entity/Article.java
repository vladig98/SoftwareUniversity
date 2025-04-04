package softuniBlog.entity;

import javax.persistence.*;

@Entity
@Table(name = "articles")
public class Article {
    private Integer id;
    private String title;
    private String content;
    private User author;

    public Article(String title, String content, User author) {
        this.title = title;
        this.content = content;
        this.author = author;
    }

    public Article() {
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return title;
    }

    @Column(columnDefinition = "text", nullable = false)
    public String getContent() {
        return content;
    }

    @ManyToOne()
    @JoinColumn(nullable = false, name = "authorId")
    public User getAuthor() {
        return author;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public void setAuthor(User author) {
        this.author = author;
    }

    @Transient
    public String getSummary()
    {
        return this.getContent().substring(0, this.getContent().length() / 2) + "...";
    }
}
